using System;
using System.Collections.Generic;

namespace Sharpr
{
	class MainClass
	{
		public static List<string> todo = new List<string>();
		
		public static void Main (string[] args)
		{
			Console.Title = "Sharpr";
			Console.WriteLine ("Welcome to Sharpr, the free project management tracker!");
			Console.ReadLine();
			Console.WriteLine("Please enter a new todo.");
			string resp = Console.ReadLine();
			
			try {
				todo.Add(resp);
				Console.WriteLine("Added " + resp + " to your list.");
				Console.ReadLine ();
			}
			catch (Exception e) { 
				Console.WriteLine("Could not add to list. Please try again later.");
			}
		}
	}
}
