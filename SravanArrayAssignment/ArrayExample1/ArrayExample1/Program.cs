using System;

namespace ArrayOne
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[, , ,] fourDArray = new string[2, 2, 2, 2];
			fourDArray [0, 0, 0, 0] = "1";
			fourDArray [0, 0, 0, 1] = "2";
			fourDArray [0, 0, 1, 0] = "3";
			fourDArray [0, 0, 1, 1] = "4";
			fourDArray [0, 1, 0, 0] = "5";
			fourDArray [0, 1, 0, 1] = "6";
			fourDArray [0, 1, 1, 0] = "7";
			fourDArray [0, 1, 1, 1] = "8";
			fourDArray [1, 0, 0, 0] = "9";
			fourDArray [1, 0, 0, 1] = "10";
			fourDArray [1, 0, 1, 0] = "11";
			fourDArray [1, 0, 1, 1] = "12";
			fourDArray [1, 1, 0, 0] = "13";
			fourDArray [1, 1, 0, 1] = "14";
			fourDArray [1, 1, 1, 0] = "15";
			fourDArray [1, 1, 1, 1] = "16";

			//Iteration
			for (int i = 0; i < fourDArray.GetLength(3); i++)
			{
				for (int j = 0; j < fourDArray.GetLength(2); j++)
				{
					for (int k = 0; k < fourDArray.GetLength(1); k++)
					{
						for(int l=0; l< fourDArray.GetLength(0); l++)
						{

							Console.WriteLine(fourDArray[i, j, k, l]);

						}

					}

				}
			}



		}
	}
}
