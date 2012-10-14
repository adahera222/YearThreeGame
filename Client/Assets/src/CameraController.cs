using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
	public Transform target;
	public float distance, height = 0f; // Will be set in the properties panel

	void LateUpdate ()
	{
		// LateUpdate is triggered after Update(), use for fixing issues where code must be triggered after the main game logic

		// Intended Pos, will be added to later
		Vector3 finalVec = target.position;

		// Displace object in reguards to the direction the target is looking
		finalVec += -target.forward * distance + new Vector3 (0, height, 0);

		// Smooth out motion. Mmmmm buttery smooth.
		finalVec = Vector3.Lerp (transform.position, finalVec, 7f * Time.deltaTime);

		// Apply the transformation
		transform.position = finalVec;

		// Look at the target
		transform.LookAt (target);
	}
	
	public Transform getTarget ()
	{
		return this.target;
	}

	public void setTarget (Transform target)
	{
		this.target = target;
	}
	
	public float gettarget ()
	{
		return this.distance;
	}

	public void setDistance (float distance)
	{
		this.distance = distance;
	}
	
	public float getHeight ()
	{
		return this.height;
	}

	public void setHeight (float height)
	{
		this.height = height;
	}
}
