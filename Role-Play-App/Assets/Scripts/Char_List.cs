using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char_List : MonoBehaviour {

	public GameObject Prefab;
	public Transform Sheet;


	GameObject ListObject;



	void Start(){
		ListObject = Instantiate (Prefab, Sheet);
		ListObject = GameObject.Find ("PlayerSheet");
		ListObject.SetActive (false);

	}

	public void AddList(){
		ListObject = Instantiate (Prefab, Sheet);


	}
	

}
