using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour {

	public GameObject image;

	public void buttonEvent(){
		if (image.active)
			image.SetActive (false);
		else
			image.SetActive (true);
		
	}

}