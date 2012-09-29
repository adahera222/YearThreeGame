using UnityEngine;
using System.Collections;

public class ABSTRACT_PlayerEntity : MonoBehaviour {
	
	int health = 100;
	int armour = 0;
	int level = 0;
	int xp = 0;
	float xpToLevel = 0; // Had to float it due to Unity's Math.Pow method only returning floats :S
	
	void __init__(int health, int armour)
	{
		this.health = health;
		this.armour = armour;
	}
	
	void __init__(int level, int health, int armour)
	{
		this.level = level;
		__init__(health, armour);	
	}
	
	void nextLevel()
	{
		level++;
		xp = 0;
		xpToLevel = 200f + (Mathf.Pow(level + 5, 3)); // THIS WORKS ALRIGHTISH, SEE http://goo.gl/wB3r2
	}
	
	// GETTERS SETTERS
	int getHealth()
	{
		return health;
	}
	
	void setHealth(int health)
	{
		this.health = health;
	}
	
	int getArmour()
	{
		return armour;	
	}
	
	void setArmour(int armour)
	{
		this.armour = armour;	
	}
	
	int getLevel()
	{
		return level;	
	}
	
	int getXp()
	{
		return xp;	
	}
	
	void setXp(int xp)
	{
		this.xp = xp;	
	}
	
}
