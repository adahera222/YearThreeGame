using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	float timeScale = 1f;
	bool multiplayer, mouseVisable = false;
	
	void Update()
	{
		// Hide the mouse
		if (mouseVisable) 
		{
			Screen.showCursor = true;
		} else {
			Screen.showCursor = false;
		}
	}
	
	public float getTimeScale()
	{
		return timeScale;	
	}
	
	public void setTimeScale(float timeScale)
	{
		this.timeScale = timeScale;
	}
	
	public void setMultiplayer(bool multiplayer)
	{
		this.multiplayer = multiplayer;
	}
	
	public void setMouseVisable(bool mouseVisable)
	{
		this.mouseVisable = mouseVisable;
	}
}
