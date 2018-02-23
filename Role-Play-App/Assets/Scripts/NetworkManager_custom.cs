using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine;

public class NetworkManager_custom : NetworkManager {

	public void startHost(){

		setPort ();
		NetworkManager.singleton.StartHost ();

	}

	public void joinGame(){

		setIpAddress ();
		setPort ();
		NetworkManager.singleton.StartClient ();

	}
	public void setIpAddress(){

		string IpAddress = GameObject.Find ("InputField").transform.Find("Text").GetComponent<Text> ().text;
		NetworkManager.singleton.networkAddress = IpAddress;

	}

	public void setPort(){

		NetworkManager.singleton.networkPort = 7777;

	}
}
