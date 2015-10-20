using System;
using System.Collections.Generic;
namespace Day6Ex4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<int> myList = new List<int>();
			myList.Add (1);
			Console.WriteLine ("Elements in list are");
			foreach (int ele in myList)
				Console.WriteLine (ele);
			myList.AddRange (new List<int> (){ 2, 3, 4,5,6,7 });
			Console.WriteLine ("Elements in list are");
			foreach (int ele in myList)
				Console.WriteLine (ele);
			myList.Remove (2);
			Console.WriteLine ("Element deleted is 2");
			Console.WriteLine ("Elements in list are");
			foreach (int ele in myList)
				Console.WriteLine (ele);
			myList.Insert (1, 2);
			Console.WriteLine ("Elements in list are");
			foreach (int ele in myList)
				Console.WriteLine (ele);
			myList.Clear ();
			Console.WriteLine ("list is cleared");



			Dictionary<int,string> myDictionary = new Dictionary<int, string> (){{1,"sravan"},{2,"Anusha"}};
			myDictionary.Add (3, "Sampath");
			Console.WriteLine ("Keys in Dictionary are");
			foreach (int ele in myDictionary.Keys)
				Console.WriteLine (ele);
			Console.WriteLine ("Values in Dictionary are");
			foreach (string ele in myDictionary.Values)
				Console.WriteLine (ele);
			myDictionary.ContainsValue ("Sampath");
			myDictionary.Remove (3);
			Console.WriteLine ("Keys in Dictionary are");
			foreach (int ele in myDictionary.Keys)
				Console.WriteLine (ele);
			Console.WriteLine ("Values in Dictionary are");
			foreach (string ele in myDictionary.Values)
				Console.WriteLine (ele);
			myDictionary.Clear ();
		}
	}
}
