﻿/*
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
	/// Description of QuestCompletionItem.
	/// </summary>
	public class QuestCompletionItem
	{
		public Item Details { get; set; }
        public int Quantity { get; set; }
            
		public QuestCompletionItem(Item details, int quantity)
		{
			Details = details;
            Quantity = quantity;
		}
	}
}
