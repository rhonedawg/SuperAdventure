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
	/// Description of PlayerQuest.
	/// </summary>
	public class PlayerQuest
	{
		public Quest Details { get; set; }
        public bool IsCompleted { get; set; }
        
		public PlayerQuest(Quest details)
		{
			
            Details = details;
            IsCompleted = false;
		}
	}
}
