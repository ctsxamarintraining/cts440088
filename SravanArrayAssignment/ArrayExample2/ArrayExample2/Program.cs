using System;

namespace ArrayExample2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[,] stringArray = new string[2, 2]{{ "abc", "def" },{"ghi","jkl"}};

			printArray (stringArray);
			int[] sampleArray = new int[9];
			sampleArray [0] = 101;
			sampleArray [1] = 102;
			sampleArray [2] = 103;
			sampleArray [3] = 104;
			sampleArray [4] = 105;
			sampleArray [5] = 105;
			sampleArray [6] = 105;
			sampleArray [7] = 105;
			sampleArray [8] = 105;
			printArray(sampleArray);


		}

		public static void printArray(Array arrayName){
			foreach (var element in arrayName) {
				Console.WriteLine (element);
			}
			Console.WriteLine ();
		}
	}
}


