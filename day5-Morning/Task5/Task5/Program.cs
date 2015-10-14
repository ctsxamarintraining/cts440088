using System;

namespace Task5
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			partialClassDemo obj = new partialClassDemo ();
			obj.printString ();
			obj.printNum ();

		}


	}
}
namespace Task5
{
	public partial class partialClassDemo
	{
		public void printString()
		{
			string s = "Varma";
			Console.WriteLine ("str is {0}", s);
		}
	}

	public partial class partialClassDemo
	{
		public void printNum()
		{
			int i = 10;
			Console.WriteLine ("num: {0}", i);
		}
	}
}
