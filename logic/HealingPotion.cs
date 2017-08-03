/*
 * Created by SharpDevelop.
 * User: Ross
 * Date: 6/26/2017
 * Time: 1:48 PM
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
	/// Description of HealingPotion.
	/// </summary>
	public class HealingPotion : Item
	{
        public int AmountToHeal { get; set; }
        
        public HealingPotion( int id, string name, string namePlural, int amountToHeal) : base (id, name, namePlural){
        	AmountToHeal = amountToHeal;
        }
    }
}

