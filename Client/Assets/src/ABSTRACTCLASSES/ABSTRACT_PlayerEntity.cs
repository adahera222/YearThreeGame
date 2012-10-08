using UnityEngine;
using System.Collections;

public class ABSTRACT_PlayerEntity : MonoBehaviour {
	
	protected int health = 100;
	protected int armour = 0;
	protected int level = 0;
	protected int xp = 0;
	protected int xpToLevel = 0; // Should return a float, the nextLevel() casts it to int
	
	protected string state = "normal"; // tags like hostile, attacking, falling, etc can be used to manage both AI and Animation
	protected GameObject target = null; // Useful for AI targeting, player's targets could be for an autoaim system
	protected GameObject objective = null; // Current event location
	
	protected void __init__(int health, int armour)
	{
		this.health = health;
		this.armour = armour;
		this.level = 0;
		nextLevel();
	}
	
	protected void __init__(int level, int health, int armour)
	{
		this.level = level - 1;
		nextLevel();
		__init__(health, armour);	
	}
	
	protected void nextLevel()
	{
		level++;
		xp = 0;
		xpToLevel = (int)(200f + (Mathf.Pow(level + 5, 3))); // THIS WORKS ALRIGHTISH, SEE http://goo.gl/wB3r2
	}
	
	public ArrayList getData()
	{
		// Setup array
		ArrayList data = new ArrayList();
		
		// Populate array
		data.Add(health);
		data.Add(armour);
		data.Add(level);
		data.Add(xp);
		data.Add(xpToLevel);
		
		//Send it off!
		return data;
	}
	
	// GETTERS SETTERS
	protected int getHealth()
	{
		return health;
	}
	
	protected void setHealth(int health)
	{
		this.health = health;
	}
	
	protected int getArmour()
	{
		return armour;	
	}
	
	protected void setArmour(int armour)
	{
		this.armour = armour;	
	}
	
	protected int getLevel()
	{
		return level;	
	}
	
	protected int getXp()
	{
		return xp;	
	}
	
	protected void setXp(int xp)
	{
		this.xp = xp;	
	}
	
}
