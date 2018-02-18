using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System;
using System.Net;
using System.IO;
using UnityEngine;

public class Server : MonoBehaviour {

	private List<serverClient> clients;
	private List<serverClient> disconnectedList;

	public int port = 3256;

	public TcpListener server;

	public bool serverStarted;

	private void Start(){

		clients = new List<serverClient> ();
		disconnectedList = new List<serverClient> ();

		try {

			server = new TcpListener(IPAddress.Any, port);
			server.Start();
			serverStarted = true;
			Debug.Log("server started on Port: " + port.ToString());

		}
		catch (Exception e){

			Debug.Log ("socket error: " + e.Message);

		}

	}

	public void Update(){

		if (!serverStarted) {
			return;
		}

		foreach (serverClient c in clients) {

			if (!isConnected (c.tcp)) {
				
				c.tcp.Close ();
				disconnectedList.Add (c);
				continue;

			} else {

				NetworkStream s = c.tcp.GetStream ();
				if (s.DataAvailable) {

					StreamReader reader = new StreamReader (s, true);
					string data = reader.ReadLine ();

					if (data != null) {

						OnIncommingData (c, data);

					}

				}

			}

		}

	}

	private void startListening(){

		server.BeginAcceptTcpClient (acceptTcpClient,server);
	}

	private bool isConnected(TcpClient c){

		try {
			if(c != null && c.Client != null && c.Client.Connected){

				if(c.Client.Poll(0,SelectMode.SelectRead)){

					return !(c.Client.Receive(new byte[1], SocketFlags.Peek) == 0);

				}

				return true;

			}else{return false;}
		}
		catch {
			return false;
		}
	}

	private void acceptTcpClient(IAsyncResult ar){

		TcpListener listener = (TcpListener)ar.AsyncState;
		clients.Add (new serverClient (listener.EndAcceptTcpClient (ar)));
		startListening ();
		//send message someone connected to server

		Broadcast (clients [clients.Count - 1].clientName + " has connected", clients);
	}

	private void OnIncommingData(serverClient c, string data){

		Debug.Log (c.clientName + " has send the following message : " + data);

	}

	private void Broadcast (string data, List<serverClient> cl){ 
	
		foreach (serverClient c in cl) {

			try {
				StreamWriter writer = new StreamWriter(c.tcp.GetStream());
				writer.WriteLine(data);
				writer.Flush();
			}
			catch(Exception e){
				Debug.Log ("write error : " + e.Message + " to client " + c.clientName);
			}

		}
	
	}
}

public class serverClient{
	 
	public TcpClient tcp;
	public string clientName;

	public serverClient(TcpClient clientSocket){

		clientName = "Guest";
		tcp = clientSocket;

	}

}
