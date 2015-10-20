using System;
using System.Linq;

namespace Two
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] array = new int[]{ 42, 10,21, 6, 7, 84,44,67 };
			var result1 = from temp in array
					where temp%7==0 && temp%3==0
				select temp;
			Console.WriteLine ("Using linQ");
			foreach (var x in result1)
			{
				Console.WriteLine (x);
			}
			var result2 = array.Where (x => x % 7 == 0 && x % 3 == 0);
			Console.WriteLine ("Using lambda");
			foreach (var y in result2)
			{
				Console.WriteLine (y);
			}
		}
	}
}
