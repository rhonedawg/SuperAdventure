/*
 * Created by SharpDevelop.
 * User: Ross
 * Date: 6/30/2017
 * Time: 1:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace engine
{
	/// <summary>
	/// Description of LivingCreature.
	/// </summary>
	public class LivingCreature
	{

			public int CurrentHitPoints{get; set;}
			public int MaximumHitPoints{get; set;}
			
			public LivingCreature(int currentHitPoints, int maxHitPoints){
				CurrentHitPoints = currentHitPoints;
				MaximumHitPoints = maxHitPoints;
				
			}
		
	}
}
