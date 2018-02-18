using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerProfile : MonoBehaviour {
	public int fastHeavy;
	public int smartStrong;
	public int luckyHandy;
	public int empathyInstincts;

	public int lifePoints;
	public int endurancePoints;
	public int psychoPoints;
	public int specialPoints;

	private int fast;
	private int smart;
	private int lucky;
	private int empathy;

	private int realfast;
	private int realsmart;
	private int reallucky;
	private int realempathy;

	public GameObject FastHeavy;
	public GameObject SmartStrong;
	public GameObject LuckyHandy;
	public GameObject EmpathyInstincts;

	string FAST;
	string SMART;
	string LUCKY;
	string EMPATHHY;

	public void Calc (int Value, string Name)
	{
		int result = 0;

		if (Value ==2 ){
			result = 5;
		}
		else if (Value ==3 ){
			result = 4;
		}
		else if (Value ==4 ){
			result = 3;
		}
		else if (Value ==5 ){
			result = 2;
		}

		if (Name == FAST) {
			fast = result;
		}
		if (Name == SMART) {
			smart = result;
		}
		if (Name == LUCKY) {
			lucky = result;
		}
		if (Name == EMPATHHY) {
			empathy = result;
		}
			
	}
		

	public void valueChangeFastHeavy ()
	{
		fastHeavy = FastHeavy.GetComponent<Dropdown>().value + 2;
	}

	public void valueChangeSmartStrong ()
	{
		smartStrong = SmartStrong.GetComponent<Dropdown>().value + 2;
	}

	public void valueChangeLuckyHandy ()
	{
		luckyHandy = LuckyHandy.GetComponent<Dropdown>().value + 2;
	}

	public void valueChangeEmpathyInstincts ()
	{
		empathyInstincts = EmpathyInstincts.GetComponent<Dropdown>().value + 2;
	}


	public void Accept ()
	{
		Calc (fastHeavy, FAST);
		realfast = fast;

		Calc (smartStrong, SMART);
		realsmart = smart;

		Calc (luckyHandy, LUCKY);
		reallucky = lucky;

		Calc (empathyInstincts, EMPATHHY);
		realempathy = empathy;

		//Calculater TEST//
		/*print (realfast);
		print (realsmart);
		print (reallucky);
		print (realempathy);*/
			
		lifePoints = 2 * fastHeavy + smartStrong + empathyInstincts;

		endurancePoints = 2 * realfast + smartStrong + luckyHandy;

		psychoPoints = 2 * realempathy + realsmart + reallucky;

		specialPoints = 2 * realsmart + reallucky + realempathy;

	}

}
