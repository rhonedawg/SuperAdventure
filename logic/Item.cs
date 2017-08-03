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
	/// Description of Class1.
	/// </summary>
	public class Item
	{
		public int ID { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; }
        
        public Item(int id, string name, string namePlural){
        	ID = id;
        	Name = name;
        	NamePlural = namePlural;
        }
	}
}
