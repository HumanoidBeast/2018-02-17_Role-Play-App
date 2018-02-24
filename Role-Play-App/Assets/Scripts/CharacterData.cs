using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterData : MonoBehaviour {

	Transform inputName;
	// Use this for initialization
	void Start () {
		inputName = gameObject.transform.Find ("inputName");
		print (inputName);
	}
	
	// Update is called once per frame
	void Update () {
		print (inputName);
	}
}
