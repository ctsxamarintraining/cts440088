using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace One
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<person> iList = new List<person>(){
				new person{ firstName = "Adams", lastName = "John" },
				new person{ firstName = "Smith", lastName = "James" },
				new person{ firstName = "Thompson", lastName = "Fred" }

			};

			Console.WriteLine ("Linq");
			var linQ1 = from element in iList orderby element.firstName descending
				select element;
			Console.WriteLine("firstName:");
			foreach (person x in linQ1) 
			{
				Console.WriteLine ("{0},{1}",x.firstName,x.lastName);
			}
			var linQ2 = from element in iList orderby element.lastName descending
				select element;
			Console.WriteLine("lastName:");
			foreach (person x in linQ2) 
			{
				Console.WriteLine ("{0},{1}",x.lastName,x.firstName);
			}


			Console.WriteLine (" ");
			Console.WriteLine("Lambda");
			Console.WriteLine("firstName:");
			var lambda1 = iList.OrderByDescending (x => x.firstName).Select (x => x);
			foreach (person x in lambda1) 
			{
				Console.WriteLine ("{0},{1}",x.firstName,x.lastName);
			}
			Console.WriteLine("lastName:");
			var lambda2 = iList.OrderByDescending (x => x.lastName).Select (x => x);
			foreach (person x in lambda2) 
			{
				Console.WriteLine ("{0},{1}",x.lastName,x.firstName);
			}

		}
		public class person
		{
			public string firstName;
			public string lastName;
		}
		}

}
