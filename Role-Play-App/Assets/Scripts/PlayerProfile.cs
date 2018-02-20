using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerProfile : MonoBehaviour {
	
	[Header("Player Stats")]

	public int fastHeavy = 2;
	public int smartStrong = 2;
	public int luckyHandy = 2;
	public int empathyInstincts = 2;
	[Space(10)]
	[Header("Player Points")]

	public int lifePoints;
	public int endurancePoints;
	public int psychoPoints;
	public int specialPoints;

	[Space(10)]
	[Header("DropDown Attributes")]

	public GameObject FastHeavy;
	public GameObject SmartStrong;
	public GameObject LuckyHandy;
	public GameObject EmpathyInstincts;
	[Space(10)]
	[Header("Sliders Attributes")]

	public Slider healthbar;
	public Slider endurancebar;
	public Slider psychobar;
	public Slider specialbar;
	[Space(10)]
	[Header("AttributeBarPointCounts")]

	public Text HPCount;
	public Text APCount;
	public Text MPCount;
	public Text PPCount;
	[Space(10)]
	[Header("AttributePointCounts")]

	public Text FastHeavyCount;
	public Text SmartStrongCount;
	public Text LuckyHandyCount;
	public Text EmpathyInstinctsCount;

	string FAST;
	string SMART;
	string LUCKY;
	string EMPATHHY;

	private int fast;
	private int smart;
	private int lucky;
	private int empathy;

	private int realfast;
	private int realsmart;
	private int reallucky;
	private int realempathy;


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
		FastHeavyCount.text = fastHeavy.ToString();
	}

	public void valueChangeSmartStrong ()
	{
		smartStrong = SmartStrong.GetComponent<Dropdown>().value + 2;
		SmartStrongCount.text = smartStrong.ToString();
	}

	public void valueChangeLuckyHandy ()
	{
		luckyHandy = LuckyHandy.GetComponent<Dropdown>().value + 2;
		LuckyHandyCount.text = luckyHandy.ToString();
	}

	public void valueChangeEmpathyInstincts ()
	{
		empathyInstincts = EmpathyInstincts.GetComponent<Dropdown>().value + 2;
		EmpathyInstinctsCount.text = empathyInstincts.ToString();
	}


	public void Accept ()
	{
		Calc (fastHeavy, FAST);
		realfast = fast;
		FastHeavyCount.text = fastHeavy.ToString();

		Calc (smartStrong, SMART);
		realsmart = smart;
		SmartStrongCount.text = smartStrong.ToString();

		Calc (luckyHandy, LUCKY);
		reallucky = lucky;
		LuckyHandyCount.text = luckyHandy.ToString();

		Calc (empathyInstincts, EMPATHHY);
		realempathy = empathy;
		EmpathyInstinctsCount.text = empathyInstincts.ToString();


				
		lifePoints = 2 * fastHeavy + smartStrong + empathyInstincts;
		setLife (healthbar, lifePoints);
		HPCount.text = lifePoints.ToString();

		endurancePoints = 2 * realfast + smartStrong + luckyHandy;
		setLife (endurancebar, endurancePoints);
		APCount.text = endurancePoints.ToString();

		psychoPoints = 2 * realempathy + realsmart + reallucky;
		setLife (psychobar, psychoPoints);
		MPCount.text = psychoPoints.ToString();

		specialPoints = 2 * realsmart + reallucky + realempathy;
		setLife (specialbar, specialPoints);
		PPCount.text = specialPoints.ToString();

	}


	public void setLife (Slider Bar, int Points) {

		Bar.maxValue = Points;
		Bar.value = Points;
	}


	public void takeDamage(int dmg, Slider Bar){

		if (Bar.value == 0)
			return;

		Bar.value -= dmg;

		Debug.Log ("damage taken: " + dmg.ToString());
	}

	public void LoadNextScene(string level)
	{
		SceneManager.LoadScene (level);
	}

}

