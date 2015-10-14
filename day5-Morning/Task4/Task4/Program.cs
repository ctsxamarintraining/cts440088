using System;
using System.Linq;
//using System.Collections.Generic;

namespace Task4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Person[] personArray = new Person[] {
				new Person{Name="Sravan",Age=23,City="hyderabad"},
				new Person{Name="Sampath",Age=47,City="Warangal"},
				new Person{Name="Rama", Age=44,City="Warangal"},
				new Person{Name="Anusha",Age=25,City="Warangal"}
			};

			var data = from person in personArray
				select new { personName = person.Name, personAge = person.Age, personCity=person.City};

			foreach (var i in data) {
				Console.WriteLine (i);
			}


		}
		class Person
		{
			public string Name{get;set;}
			public int Age{get;set;}
			public string City{get;set;}
		}
	}
}

