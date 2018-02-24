using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterData : MonoBehaviour {

	public InputField nameField;
	public InputField raceField;
	public InputField originField;
	public InputField universeField;
	public InputField ageField;

	public string charName;
	public string raceName;
	public string originName;
	public string universeName;
	public string ageName;

	void Update () {
		
		charName = nameField.text;
		raceName = raceField.text;
		originName = originField.text;
		universeName = universeField.text;
		ageName = ageField.text;

	}

}
