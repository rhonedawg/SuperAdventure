﻿/*
 * Created by SharpDevelop.
 * User: Ross
 * Date: 6/26/2017
 * Time: 1:52 PM
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
	/// Description of Quest.
	/// </summary>
	public class Quest
	{
		public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public Item RewardItem { get; set; }
        public List<QuestCompletionItem> QuestCompletionItems {get; set;}
        
        public Quest(int id, string name, string description, int rewardExp, int rewardgold, Item rewardItem = null){
        	ID = id;
        	Name = name;
        	Description = description;
        	RewardExperiencePoints = rewardExp;
        	RewardGold = rewardgold;
        	RewardItem = rewardItem;
        	QuestCompletionItems = new List<QuestCompletionItem>();
        }
	}
}
