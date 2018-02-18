using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.IO;
using System;
using UnityEngine.UI;
using UnityEngine;

public class Client : MonoBehaviour {

	private bool socketReady;
	private TcpClient socket;
	private NetworkStream stream;
	private StreamWriter writer;
	private StreamReader reader;

	public void connectToServer(){

		if (socketReady) 
			return;

		string host = "127.0.0.1";
		int port = 3256;

		string h;
		int p;

		h = GameObject.Find ("HostInput").GetComponent<InputField>().text;
		if (h != "") 
			host = h;

		int.TryParse (GameObject.Find ("PortInput").GetComponent<InputField> ().text, out p);
		if(p != 0)
			port = p;

		try {
			socket = new TcpClient(host,port);
			stream = socket.GetStream();
			writer = new StreamWriter(stream);
			reader = new StreamReader(stream);

			socketReady = true;
		}

		catch(Exception e) {
			Debug.Log("Socket error : " + e.Message);
		}

	}

	private void Update(){

		if (socketReady) {
		
			if (stream.DataAvailable) {

				string data = reader.ReadLine ();
				if (data != null)
					OnIncomingData (data);
			}

		}

	}

	private void OnIncomingData (string data){

		Debug.Log ("server: " + data);

	}

}
