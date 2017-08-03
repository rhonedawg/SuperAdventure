/*
 * Created by SharpDevelop.
 * User: Ross
 * Date: 6/26/2017
 * Time: 1:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace engine
{
	/// <summary>
	/// Description of Monster.
	/// </summary>
	public class Monster : LivingCreature
	{
		public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public List<LootItem> LootTable { get; set;}
        
        public Monster(int id, string name, int maxiumumDamage, int rewardExp, int rewardGold, int currentHitPoints, int maxHitPoints)
        	: base(currentHitPoints, maxHitPoints){
        	ID = id;
        	Name = name;
        	MaximumDamage = maxiumumDamage;
        	RewardExperiencePoints = rewardExp;
        	RewardGold = rewardGold;
        	LootTable = new List<LootItem>();
        	
        }
	}
}
