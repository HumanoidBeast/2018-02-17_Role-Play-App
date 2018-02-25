using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityBuild : MonoBehaviour {

	[Space(5)][Header("Clock")]
	public GameObject Minute;
	public GameObject HalfHour;
	public GameObject ThreeHours;
	public GameObject Day;
	public Text durationDisplay;
	public int Duration = 10;

	[Space(2)][Header("Special")]
	public GameObject Special;
	public GameObject Normal;
	public bool special = false;


	public void ClockSet() {
		if (Duration == 10) {
			Minute.SetActive (true);
			Duration = 60;
			durationDisplay.text = "One minute";
		} else if (Duration == 60) {
			Minute.SetActive (false);
			HalfHour.SetActive (true);
			Duration = 1800;
			durationDisplay.text = "Half an hour";
		} else if (Duration == 1800) {
			HalfHour.SetActive (false);
			ThreeHours.SetActive (true);
			Duration = 9600;
			durationDisplay.text = "Three Hours";
		} else if (Duration == 9600) {
			ThreeHours.SetActive (false);
			Day.SetActive (true);
			Duration = 76800;
			durationDisplay.text = "All day long";
		} else if (Duration == 76800) {
			Day.SetActive (false);
			Duration = 10;
			durationDisplay.text = "A few seconds";
		}
	}

	public void SpecialSet() {

		if (special == false) {
			Special.SetActive (true);
			Normal.SetActive (false);
			special = true;
		} else {
			Special.SetActive (false);
			Normal.SetActive (true);
			special = false;
		}
	}

}
