using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour {

	public static SaveManager save;
	// Use this for initialization
	void Awake () {
		if (save == null) {
			DontDestroyOnLoad (gameObject);
			save = this;
		} else if (save != this){
			Destroy (gameObject);
		}
	}
	public void Save(){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/saveData.dat");

		SaveData data = new SaveData ();
		//Write all Values to save: data.health = health;

		bf.Serialize (file, data);
		file.Close ();
	}	
	public void Load(){
		if (File.Exists (Application.persistentDataPath + "/saveData.dat")) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + "/saveData.dat", FileMode.Open);
			SaveData data = (SaveData)bf.Deserialize (file);
			file.Close ();
			//Write all Values to load: health = data.health;

		}	
	}

}
[Serializable]
class SaveData
{
		//Write all Datatypes that you wanna be able to Store here: public int health;

}