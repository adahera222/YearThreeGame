using UnityEngine;
using System.Collections;

public class SkillMelee : ABSTRACT_Skill {

	private void __init__()
	{
		int level = 5; // TODO: Grab this from the player/npc that this skill is attached to
		skillName = "Punch";
		skillDescription = "A simple melee attack. Punches your target";
		skillCastTime = 0f;
		skillCoolDown = 0.7f;
		skillDamage = (level * 17) + 20;
	}
	
	// TODO: Finish this
	private void useSkill()
	{
		if (canUse)
		{
			canUse = false;
			if (skillCastTime > 0f)
			{
				// Wait until time has passed
				// Do something/use skill
			} else {
				// Do something/use skill
			}
			
			if (skillCoolDown > 0f)
			{
				// Wait
			}
			
			canUse = true; // Make skill useable
		}
	}
	
}
