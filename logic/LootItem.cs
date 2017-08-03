/*
 * Created by SharpDevelop.
 * User: Ross
 * Date: 7/10/2017
 * Time: 2:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace engine
{
	/// <summary>
	/// Description of LootItem.
	/// </summary>
	public class LootItem
	{
		public Item Details { get; set; }
        public int DropPercentage { get; set; }
        public bool IsDefaultItem { get; set; }
        
		public LootItem(Item details, int dropPercentage, bool isDefaultItem)
		{
			Details = details;
            DropPercentage = dropPercentage;
            IsDefaultItem = isDefaultItem;
		}
	}
}
