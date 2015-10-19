using System;
using Newtonsoft.Json;

namespace Serialization
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Product productobj = new Product() {
				ProductName="Mac",ProductID="SCkiui",DepartmentName="Mobility",DepartmentID=78977099,Company="Cognizant",Warranty=3
			};

			//serialization
			string output = JsonConvert.SerializeObject(productobj);
			Console.Write ("Serialized Data:{0}",output);

			Console.WriteLine (" ");
			Console.WriteLine (" ");
			//Deserialization
			Console.WriteLine ("DeSerialized Data:{0}",JsonConvert.DeserializeObject(output));
			
		}
	}
}
	