using UnityEngine;
using System.Collections;

public class ABSTRACT_PlayerEntity : MonoBehaviour {
	
	int health = 100;
	int armour = 0;
	
	
	void __init__()
	{
		
	}
	
	void __init__(int health, int armour)
	{
		this.health = health;
		this.armour = armour;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
