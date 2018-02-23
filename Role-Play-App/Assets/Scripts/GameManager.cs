using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

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
