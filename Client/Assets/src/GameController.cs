using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	float timeScale = 1f;
	bool mutliplayer = false;
	
	float getTimeScale()
	{
		return timeScale;	
	}
	
	void setTimeScale(float timeScale)
	{
		this.timeScale = timeScale;
	}
}
