using System;

namespace TaskOne
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string str = Console.ReadLine();
			Console.WriteLine("no. of words are : {0} ",str.Words());
			Console.WriteLine("no. of Characters are : {0} ",str.Characters());
		}
	}


	public static class ExtensionClass
	{

		public static int Words(this string s)
		{
			string[] wordsArray=s.Split((string[]) null, StringSplitOptions.RemoveEmptyEntries);
			return wordsArray.Length;
		}
		public static int Characters(this string charString)
		{
			int count = 0;
			string[] wordsArray=charString.Split((string[]) null, StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < wordsArray.Length; i++)
			{
				int length = wordsArray [i].Length;
				count = count + length;
			}
			return count;
		}

	}
}
