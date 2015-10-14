using System;

namespace Task3
{
	class MainClass
	{
		delegate void sampleDelegate(int x);

		public static void Method1(int n)
		{
			Console.WriteLine ("Number is {0}",n);
		}

		public static void Main (string[] args)
		{

			sampleDelegate mydelegate=delegate(int num){
				Console.WriteLine("this is an anonymous delegate method {0}",num);
			};
			mydelegate(99);

			mydelegate = new sampleDelegate (Method1);
			mydelegate(65);

		}
	}
}
