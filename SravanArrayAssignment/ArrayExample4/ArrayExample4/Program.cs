using System;
using System.Collections.Generic;

namespace ArrayExample4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Person p1 = new Person ();
			p1.firstName=@"Sravan";
			p1.lastName=@"Varma";
			p1.age = 22;

			Person p2 = new Person ();
			p2.firstName=@"Rama";
			p2.lastName=@"Devi";
			p2.age = 43;

			Person p3 = new Person ();
			p3.firstName=@"Sampath";
			p3.lastName=@"Kumar";
			p3.age = 47;

			Person p4 = new Person ();
			p4.firstName=@"Anusha";
			p4.lastName=@"Appana";
			p4.age = 25;
			Person [] personsArray = new Person[]{p1,p2,p3,p4 };

			MyComparer c = new MyComparer ();
			Array.Sort (personsArray,c);
			foreach (Person p in personsArray) {
				Console.WriteLine (p.firstName);
			};
		}

	}

	class Person
	{
		public string firstName{ get; set; }
		public string lastName{ get; set; }
		public int age{ get; set; }

	}
	class MyComparer : IComparer<Person>
	{
		public int Compare(Person p1, Person p2)
		{
			return p1.lastName.CompareTo(p2.lastName);
		}
	}

}
	