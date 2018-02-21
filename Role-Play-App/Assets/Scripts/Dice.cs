using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Dice : MonoBehaviour {

	public GameObject PlayerStats;
	public GameObject dropDownAttribute;
	public Text DiceC;
	public int rand;
	public int AttributeCount;

	public int FH;
	public int SS;
	public int LH;
	public int EI;

	void Update()
	{
		if (AttributeCount == 1) {//fastHeavy
			FH = PlayerStats.GetComponent<PlayerProfile> ().FH;
		}
	}

	public void SetAttribute()
	{
		AttributeCount = dropDownAttribute.GetComponent<Dropdown> ().value+1;
	}


	public void RollDice()
	{
		if (dropDownAttribute == null) {
			return;
		}
		rand = Random.Range (2, 6);
		DiceC.text = rand.ToString ();
	}
		
}
