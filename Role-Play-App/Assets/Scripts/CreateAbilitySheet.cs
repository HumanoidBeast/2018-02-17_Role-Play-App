using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;
using UnityEngine;
using UnityEngine.UI;

public class CreateAbilitySheet : MonoBehaviour {

	//Create new AbilitySheet
	BaseSheetClass AbilitySheet = new BaseSheetClass ();

	[Header("Preview")]
	public string AbilityNamePreview;

	[Header("AbilitySheet")]
	public GameObject SheetPref;
	public Transform SheetPos;
	public float setDown;


	//private
	float SetDown;
	GameObject Sheet;
	GameObject AbiliBuild;
	public GameObject AbiliName;

	void Start(){
		SetDown = setDown;
		AddAbilitySheet ();
	}

	void Update(){
		//Update Gui_AbilityInput to AbilitySheet_Data


		AbilitySheet.AbilityName = AbiliName.GetComponent<InputField> ().text;
		 


		//Update AbilitySheet_Data to Gui_Preview
		SaveManager.save.abilityName = AbilitySheet.AbilityName;
		AbilityNamePreview = AbilitySheet.AbilityName;



	}

	public void CreateAbility(){

		SaveManager.save.Save ();
		AddAbilitySheet ();

	}


	public void AddAbilitySheet(){
		
		Sheet = Instantiate (SheetPref,SheetPos );
		Sheet.transform.position += new Vector3 (0, -SetDown,0);

		AbiliBuild = Sheet.transform.Find("AbilityBuild").gameObject;
		AbiliName = AbiliBuild.transform.Find ("AbilityName").gameObject;

		SetDown += setDown;
	

	}

}
