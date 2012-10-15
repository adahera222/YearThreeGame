using UnityEngine;
using System.Collections;

public abstract class ABSTRACT_Skill : MonoBehaviour {
	protected bool canUse = true;
	protected string skillName, skillDescription = "";
	protected float skillCastTime, skillCoolDown, skillDamage = 0f;
	protected Texture2D skillIcon;
}
