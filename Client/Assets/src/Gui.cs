using UnityEngine;
using System.Collections;

public class Gui : MonoBehaviour {
	
	public Texture2D guiBarBg;
	public Texture2D guiBarHealth;
	public Texture2D guiBarArmour;
	public Texture2D guiBarFg;
	public Texture2D guiXpBg;
	public Texture2D guiXpMain;
	
	private int health = 100;
	private int armour = 0;
	private int level = 0;
	private int xp = 0;
	private int xpToLevel = 0;
	
	// Constants
	private static int SW, SH = 0;
	private static float PADDING = 0f;
	
	// Percentages
	private float xpPer, xpPercent = 1f;
	
	
	// Update is called once per frame
	void Start()
	{
		PADDING = 10f;	
	}
	
	void Update () {
		// Update screenheight and screenwidth
		SW = Screen.width;
		SH = Screen.height;
		
		// Grab data from player
		ArrayList data = gameObject.GetComponent<PlayerController>().getData(); // For this to work a player controller must be attached to the same gameObject
		health = (int)data[0];
		armour = (int)data[1];
		level = (int)data[2];
		xp = (int)data[3];
		xpToLevel = (int)data[4];
		
		// Calculate Percentages
		xpPer = (float)xp / (float)xpToLevel;
		xpPercent = Mathf.Lerp (xpPercent, xpPer, Time.deltaTime * 8);
	}
	
	void OnGUI()
	{
		// Top left debugging
		string data = "Health: "+health+"\nArmour: "+armour+"\nLevel: "+level+"\nXP: "+xp+"\nToLevel: "+xpToLevel;
		GUI.TextField(new Rect(PADDING, PADDING, SW/3 - PADDING*2, SH/2 - PADDING*2), data);
		
		//XPBar
		/*Rect barPos = new Rect(PADDING, SH - PADDING*2 - guiBarBg.height, guiBarBg.width, guiBarBg.height);
		Rect barPosXp = new Rect(PADDING, SH - PADDING*2 - guiBarBg.height, guiBarBg.width * xpPercent, guiBarBg.height);
		
		GUI.DrawTexture(barPos, guiBarBg);
		GUI.DrawTexture(barPosXp, guiBarXp, ScaleMode.StretchToFill);
		GUI.DrawTexture(barPos, guiBarFg);*/
		
		// Xp Bar
		Rect xpBarPos = new Rect(0, SH - guiXpBg.height, SW, guiXpBg.height);
		Rect xpBarPercent = new Rect(0, SH - guiXpBg.height, SW * xpPercent, guiXpBg.height);
		GUI.DrawTexture(xpBarPos, guiXpBg);
		GUI.DrawTexture(xpBarPercent, guiXpMain, ScaleMode.StretchToFill);
	}
}
