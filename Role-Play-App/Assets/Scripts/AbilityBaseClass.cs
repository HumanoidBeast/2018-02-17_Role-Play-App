using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityBaseClass : MonoBehaviour {

	string abilityName;

	bool special;

	int clock;

	string attributeOne;
	string attributeTwo;
	string attributeThree;

	string energyType;
	int energyValue;

	string damageType;
	int damageValue;
	bool heal;

	public string AbilityName{
		get{ return abilityName; }
		set{ abilityName = value; }
	}
	public bool Special{
		get{ return special; }
		set{ special = value; }
	}
	public int Clock{
		get{ return clock; }
		set{ clock = value; }
	}
	public string AttributeOne{
		get{ return attributeOne; }
		set{ attributeOne = value; }
	}
	public string AttributeTwo{
		get{ return attributeTwo; }
		set{ attributeTwo = value; }
	}
	public string AttributeThree{
		get{ return attributeThree; }
		set{ attributeThree = value; }
	}
	public string EnergyType{
		get{ return energyType; }
		set{ energyType = value; }
	}
	public int EnergyValue{
		get{ return energyValue; }
		set{ energyValue = value; }
	}
	public string DamageType{
		get{ return damageType; }
		set{ damageType = value; }
	}
	public int DamageValue{
		get{ return damageValue; }
		set{ damageValue = value; }
	}
	public bool Heal{
		get{ return heal; }
		set{ heal = value; }
	}

}
