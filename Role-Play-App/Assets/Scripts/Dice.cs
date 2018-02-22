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


	public void SetAttribute()
	{
		AttributeCount = dropDownAttribute.GetComponent<Dropdown> ().value+1;
		FH = PlayerStats.GetComponent<PlayerProfile> ().FH;
		SS = PlayerStats.GetComponent<PlayerProfile> ().SS;
		LH = PlayerStats.GetComponent<PlayerProfile> ().LH;
		EI = PlayerStats.GetComponent<PlayerProfile> ().EI;
	}
		
	public void RollDice()
	{
		if (dropDownAttribute == null) {
			return;
		}
			
		rand = Random.Range (1, 7);
		DiceC.text = rand.ToString ();


		if (AttributeCount == 1) {//fast
			Rollup(FH);
		}
		if (AttributeCount == 2) {//smart
			Rollup(SS);
		}
		if (AttributeCount == 3) {//lucky
			Rollup(LH);
		}
		if (AttributeCount == 4) {//Empathy
			Rollup(EI);
		}


		if (AttributeCount == 5) {//heavy
			Rolldown(FH);
		}
		if (AttributeCount == 6) {//strong
			Rolldown(SS);
		}
		if (AttributeCount == 7) {//handy
			Rolldown(LH);
		}
		if (AttributeCount == 8) {//instincts
			Rolldown(EI);
		}
	}

	void Rolldown(int Att)
	{
		if (rand <= Att) {
			print ("U did it");
		} else {
			print ("Don't!");
		}
	}

	void Rollup(int Att)
	{
		if (rand >= Att) {
			print ("U did it");
		} else {
			print ("Don't!");
		}
	}
		
}
