using UnityEngine;
using System.Collections;

public class PlayerController : ABSTRACT_PlayerEntity {

	public float moveRate = 1f;
	public float turnRate = 2f;
	
	void Update () {
	
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
}
