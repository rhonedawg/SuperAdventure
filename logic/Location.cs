/*
 * Created by SharpDevelop.
 * User: Ross
 * Date: 6/26/2017
 * Time: 1:50 PM
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
	/// Description of Location.
	/// </summary>
	public class Location
	{
		public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Location LocationToNorth { get; set;}
        public Location LocationToSouth { get; set;}
        public Location LocationToWest { get; set;}
        public Location LocationToEast { get; set;}
        public Item ItemRequiredToEnter { get; set;}
        public Quest QuestAvailableHere { get; set;}
        public Monster MonsterLivingHere { get; set;}
        
        
        
        public Location(int id, string name, string description, 
            Item itemRequiredToEnter = null, Quest questAvaiableHere = null, Monster monsterHere = null) {
        	
        	ID = id;
        	Name = name;
        	Description = description;
        	ItemRequiredToEnter = itemRequiredToEnter;
        	QuestAvailableHere = questAvaiableHere;
        	MonsterLivingHere = monsterHere;
        	
        	
        }
	}
}
