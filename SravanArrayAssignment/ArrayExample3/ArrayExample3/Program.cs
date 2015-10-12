using System;

namespace ArrayExample3
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

			Array.Sort (personsArray);
			foreach (Person p in personsArray) {
				Console.WriteLine (p.firstName);
			};
		}
	}

	class Person:IComparable<Person>
	{
		public string firstName{ get; set; }
		public string lastName{ get; set; }
		public int age{ get; set; }

		public int CompareTo(Person person)
		{
			return person.age.CompareTo(this.age);
		}


	}

}
