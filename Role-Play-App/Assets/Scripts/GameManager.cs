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


	public void Add(int points, int maxPoints, int pointPool){
		if ((points == maxPoints) || (pointPool == 0)) {
			return;
		} else {
			points ++;
			pointPool --;
		}	
	}	
	public void Sub(int points, int maxPoints, int pointPool){
		if (points == 0){
			return;
		} else {
			points --;
			pointPool ++;
		}	
	}	
}
