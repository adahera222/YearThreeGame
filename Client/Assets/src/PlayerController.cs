using UnityEngine;
using System.Collections;

public class PlayerController : ABSTRACT_PlayerEntity {

	public float moveRate = 1f;
	public float turnRate = 2f;
	
	private ArrayList skill = new ArrayList();

	void Start()
	{
		// Set up the player at lvl 1, with 100 health/armour
		__init__(1, 100, 100);
	}
	
	void Update () {
		logic();
		movement();
		abilities();
		debugging();
	}
	
	void logic()
	{
		if (xp > xpToLevel)
			nextLevel();
	}
	
	void movement()
	{
		float vx = Input.GetAxis("Horizontal");
		float vz = Input.GetAxis("Vertical");
		float mx = Input.GetAxis("Mouse X");
		
		if (Input.GetKey(KeyCode.LeftShift)) vz *= 2;
		
		// Move character in reguards to the direction it's facing
		transform.Translate(transform.InverseTransformDirection(transform.forward * vz / 10));
		transform.Translate(transform.InverseTransformDirection(transform.right * vx / 10));
		
		// Rotate
		transform.Rotate(new Vector3(0,mx * turnRate,0));
	}
	
	void abilities()
	{
		// Keyboard keys 1->4 (skills)
		if (Input.GetKey(KeyCode.Alpha1))
		{
			// Do something
		}
		if (Input.GetKey(KeyCode.Alpha2))
		{
		}
		if (Input.GetKey(KeyCode.Alpha3))
		{
		}
		if (Input.GetKey(KeyCode.Alpha4))
		{
		}
	}
	
	void debugging()
	{
		if (Input.GetKey(KeyCode.Keypad0)) health--;
		if (Input.GetKey(KeyCode.Keypad1)) health++;
		if (Input.GetKey(KeyCode.Keypad4)) armour--;
		if (Input.GetKey(KeyCode.Keypad7)) armour++;
		if (Input.GetKey(KeyCode.Keypad6)) xp--;
		if (Input.GetKey(KeyCode.Keypad9)) xp++;
		if (Input.GetKeyDown(KeyCode.Keypad5)) nextLevel();
		if (Input.GetKeyDown(KeyCode.Keypad8)) xp += 100;
	}
}
