using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour {

	public string LoadFile;


	public string abilityName;

	public bool special;

	public int clock;

	public string attributeOne;
	public string attributeTwo;
	public string attributeThree;

	public string energyType;
	public int energyValue;

	public string damageType;
	public int damageValue;
	public bool heal;

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
		string SaveFileName = "/" + abilityName + ".dat";
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/"+ SaveFileName +".dat");

		AbilityData data = new AbilityData ();
		//Write all Values to save: data.health = health;

		data.abilityName = abilityName;
		Debug.Log ("Saved to:" + Application.persistentDataPath);

		bf.Serialize (file, data);
		file.Close ();
	}	
	public void Load(){
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + "/" + LoadFile, FileMode.Open);
			AbilityData data = (AbilityData)bf.Deserialize (file);

			abilityName = data.abilityName;

			file.Close ();
			//Write all Values to load: health = data.health;
	
	}


}
[Serializable]
class AbilityData
{
	public string abilityName;

	public bool special;

	public int clock;

	public string attributeOne;
	public string attributeTwo;
	public string attributeThree;

	public string energyType;
	public int energyValue;

	public string damageType;
	public int damageValue;
	public bool heal;

}