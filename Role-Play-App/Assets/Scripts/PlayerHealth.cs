using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	public Slider healthbar;
	public GameObject attribute;

	// Use this for initialization
	public void setLife () {

		healthbar.value = attribute.GetComponent<PlayerProfile> ().lifePoints;

		healthbar.maxValue = attribute.GetComponent<PlayerProfile> ().lifePoints;
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
