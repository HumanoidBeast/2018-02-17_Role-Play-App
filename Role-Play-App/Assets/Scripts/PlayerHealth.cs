using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	public Slider healthbar;
	public Slider endurancebar;
	public Slider psychobar;
	public Slider specialbar;
	public Text maxhealth;
	public Text maxendurance;
	public Text maxpsycho;
	public Text maxspecial;
	public GameObject attribute;

	// Use this for initialization
	public void setLife () {

		healthbar.value = attribute.GetComponent<PlayerProfile> ().lifePoints;
		healthbar.maxValue = attribute.GetComponent<PlayerProfile> ().lifePoints;
		maxhealth.text = attribute.GetComponent<PlayerProfile> ().lifePoints.ToString();

		endurancebar.value = attribute.GetComponent<PlayerProfile> ().endurancePoints;
		endurancebar.maxValue = attribute.GetComponent<PlayerProfile> ().endurancePoints;
		maxendurance.text = attribute.GetComponent<PlayerProfile> ().endurancePoints.ToString();

		psychobar.value = attribute.GetComponent<PlayerProfile> ().psychoPoints;
		psychobar.maxValue = attribute.GetComponent<PlayerProfile> ().psychoPoints;
		maxpsycho.text = attribute.GetComponent<PlayerProfile> ().psychoPoints.ToString();

		specialbar.value = attribute.GetComponent<PlayerProfile> ().specialPoints;
		specialbar.maxValue = attribute.GetComponent<PlayerProfile> ().specialPoints;
		maxspecial.text = attribute.GetComponent<PlayerProfile> ().specialPoints.ToString();

	}
	
	// Update is called once per frame
	void Update () {

	}

	public void takeDamage(int dmg){

		if (healthbar.value == 0)
			return;
		
		healthbar.value -= dmg;

		Debug.Log ("damage taken: " + dmg.ToString());
	}
}
