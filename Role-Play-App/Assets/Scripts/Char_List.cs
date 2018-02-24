using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char_List : MonoBehaviour {
	[Header("Prefab's")]
	public GameObject SheetPref;

	[Space(1)][Header("SpawnPositon")]
	public GameObject SheetPos;

	GameObject CharacterSheet;


	public void AddList(){
		CharacterSheet = Instantiate (SheetPref,SheetPos.transform) as GameObject;
		Destroy (this);



	}


}
