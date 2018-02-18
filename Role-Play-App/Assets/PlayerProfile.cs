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


	public GameObject FastHeavy;
	public GameObject SmartStrong;
	public GameObject LuckyHandy;
	public GameObject EmpathyInstincts;


	public void Calc (int Value, int result)
	{

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
		print (result);

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
		Calc (fastHeavy,fast);
		Calc (smartStrong,smart);
		Calc (luckyHandy,lucky);
		Calc (empathyInstincts,empathy);

	
		lifePoints = 2 * fastHeavy + smartStrong + empathyInstincts;

		endurancePoints = 2 * fast + smartStrong + luckyHandy;

		psychoPoints = 2 * empathy + smart + lucky;

		specialPoints = 2 * smart + lucky + empathy;

	}

}
