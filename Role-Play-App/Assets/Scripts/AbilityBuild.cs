using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityBuild : MonoBehaviour {

	[Space(10)][Header("Clock")]
	public GameObject TimeTier1;
	public GameObject TimeTier2;
	public GameObject TimeTier3;
	public GameObject TimeTier4;
	public Text durationDisplay;
	public int Duration = 10;
	[Space(1)][Header("ClockTier0")]
	public int tierZeroValue = 10;
	public string tierZeroText = "A few seconds";
	[Space(1)][Header("ClockTier1")]
	public int tierOneValue = 60;
	public string tierOneText = "One minute";
	[Space(1)][Header("ClockTier2")]
	public int tierTwoValue = 1800;
	public string tierTwoText = "Half an hour";
	[Space(1)][Header("ClockTier3")]
	public int tierThreeValue = 9600;
	public string tierThreeText = "Three Hours";
	[Space(1)][Header("ClockTier4")]
	public int tierFourValue = 76800;
	public string tierFourText = "All day long";

	[Space(2)][Header("Special")]
	public GameObject Special;
	public GameObject Normal;
	public bool special = false;


	public void ClockSet() {
		if (Duration == tierZeroValue) {
			TimeTier1.SetActive (true);
			Duration = tierOneValue;
			durationDisplay.text = tierOneText;
		} else if (Duration == tierOneValue) {
			TimeTier1.SetActive (false);
			TimeTier2.SetActive (true);
			Duration = tierTwoValue;
			durationDisplay.text = tierTwoText;
		} else if (Duration == tierTwoValue) {
			TimeTier2.SetActive (false);
			TimeTier3.SetActive (true);
			Duration = tierThreeValue;
			durationDisplay.text = tierThreeText;
		} else if (Duration == tierThreeValue) {
			TimeTier3.SetActive (false);
			TimeTier4.SetActive (true);
			Duration = tierFourValue;
			durationDisplay.text = tierFourText;
		} else if (Duration == tierFourValue) {
			TimeTier4.SetActive (false);
			Duration = tierZeroValue;
			durationDisplay.text = tierZeroText;
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
