using System;
using System.Collections.Generic;

namespace Day6Ex5
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Dictionary<student,int> studentList1 = new Dictionary<student,int>(new MyEqualityComparer()){
				{new student{id=1,firstname="Adam"},1},
				{new student{id=2,firstname="John"},2},
				{new student{id=2,firstname="Thompson"},3}
			};
			Console.WriteLine ("IEqualityComparer");

			foreach (student p in studentList1.Keys)
				Console.WriteLine (p.firstname);
			List<student> myList = new List<student> {
				new student{ id = 1, firstname = "Adam" },
				new student{ id = 6, firstname = "Mike" },
				new student{ id = 4, firstname = "Rachel" },
				new student{ id = 5, firstname = "Chandler" }
			};
			Console.WriteLine (" ");
			Console.WriteLine (" ");
			Console.WriteLine ("IComparer");
			myList.Sort (new MyComparer ());
			foreach(student p in myList)
				Console.WriteLine (p.firstname);
		}
	}

	class student{
		public string firstname;
		public int id;
	}
	class MyEqualityComparer : IEqualityComparer<student>{

		public bool Equals (student x, student y)
		{
			return x.id==y.id;
		}
		public int GetHashCode (student obj)
		{
			return obj.GetHashCode ();
		}

	}
	class MyComparer : IComparer<student>{

		public int Compare (student s1, student s2)
		{
			return s1.firstname.CompareTo (s2.firstname);
		}

	}
}
	