using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;
using UnityEngine;
using UnityEngine.UI;

public class AbillityList : MonoBehaviour {

	public GameObject SheetPref;
	public Transform SheetPos;
	public float setdown;

	float SetDown;
	GameObject Sheet;
	GameObject AbiliSheet;
	GameObject AbiliName;

	void Start(){
		SetDown = setdown;
		AbilityLoad ();

	}



	public void AbilityLoad(){

		DirectoryInfo dir = new DirectoryInfo (Application.persistentDataPath);
		FileInfo[] info = dir.GetFiles ("*.dat");
		foreach (FileInfo AbilityFile in info) {
			//print (Herofile.Name);#
			SaveManager.save.LoadFile = AbilityFile.Name;
			SaveManager.save.Load();

			AddSheet (SaveManager.save.abilityName);

		}

	}


	void AddSheet(string Name){

		Sheet = Instantiate (SheetPref,SheetPos);
		Sheet.transform.position += new Vector3 (0 , -SetDown, 0);
		AbiliSheet = Sheet.transform.Find ("AbilitySheet").gameObject;
		AbiliName = AbiliSheet.transform.Find ("AbilityName").gameObject;
		AbiliName.GetComponent<Text> ().text = Name;

		SetDown += setdown;

	}
}
