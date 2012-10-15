using UnityEngine;
using System.Collections;

public class ABSTRACT_TriggerZone : MonoBehaviour {
	
	/*
	 * This abstract class will define basic trigger volume parameters for a trigger volume for engaging game events
	 * It also creates the collisionMesh and defines it's height and radius (the collision mesh is cylindrical)
	 */
	
	protected string triggerName = "";
	protected CapsuleCollider col = new CapsuleCollider();
	
	void __init__(float radius)
	{
		col.radius = radius;	
	}
	
	void __init__(float radius, float height)
	{
		__init__ (radius);
		col.height = height;
	}
}
