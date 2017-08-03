/*
 * Created by SharpDevelop.
 * User: Ross
 * Date: 6/26/2017
 * Time: 1:53 PM
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
	/// Description of Weapon.
	/// </summary>
	public class Weapon : Item
	{
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
        
        public Weapon(int id, string name, string namePlural, int maxDamg, int minDamg) : base(id, name, namePlural){
        	MinimumDamage = minDamg;
        	MaximumDamage = maxDamg;
        }
	}
}
