using System;

namespace Task2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Nullable<int> sample = null;
			Console.WriteLine ("sample :?{0}",sample.HasValue);
			sample = 30;
			Console.WriteLine ("sample :?{0}",sample.HasValue);
			Console.WriteLine ("value of sample is{0}:",sample.Value);
			sample = 13;
			Console.WriteLine ("sample :?{0}",sample.HasValue);
			Console.WriteLine ("value of sample is{0}:",sample.Value);
		}
	}
}
