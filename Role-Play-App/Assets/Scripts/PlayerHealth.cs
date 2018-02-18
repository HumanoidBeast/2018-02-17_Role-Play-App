using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	public Slider healthbar;

	// Use this for initialization
	void Start () {

		healthbar.value = 100;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
