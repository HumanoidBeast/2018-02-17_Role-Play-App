using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ChooseSkill : MonoBehaviour {


	public static int Points = 0;
	public static int MaxPoints = 3;
	public static int PointPool = 10;
	public Text Pool;
	public Text SkillPoints;


	public void UpPressed (){
		
		if ((Points == MaxPoints) || (PointPool == 0)) {
			return;
		} else {
			Points ++;
			PointPool --;
			SkillPoints.text = Points.ToString ();
			Pool.text = "Points left: " + PointPool.ToString ();
			print (Points);
			print (PointPool);
		}	

	}
	public void DownPressed (){
		if (Points == 0){
			return;
		} else {
			Points --;
			PointPool ++;
			SkillPoints.text = Points.ToString ();
			Pool.text = "Points left: " + PointPool.ToString ();
			print (Points);
			print (PointPool);
		}
		}	


}
