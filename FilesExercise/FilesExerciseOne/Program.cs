using System;
using System.IO;

namespace FilesExerciseOne
{
	class MainClass
	{
		public static void Main (string[] args)
		{


			string oldFilepath=@"C:\Users\Public\log.txt";
			
						//Writing text to a new file
			string text = "C# pronounced as see sharp is a multi-paradigm " +
				"programming language encompassing strong typing, " +
				"imperative, declarative, functional, generic, object-oriented " +
				"(class-based), and component-oriented programming disciplines. " +
				"It was developed by Microsoft within its .NET initiative and later" +
				" approved as a standard by Ecma and ISO. " +
				"C# is one of the programming languages designed for the Common Language" +
				" Infrastructure.";
						System.IO.File.WriteAllText(oldFilepath, text);
			
			
						//reading text from the path
						string readText = File.ReadAllText(oldFilepath);
						Console.WriteLine ("original Text is:{0}",readText);
			Console.WriteLine (" ");

						//Reversing the text
						char[] separators = new char[]{ '.' };
						string[] stringsArray = readText.Split (separators,StringSplitOptions.RemoveEmptyEntries);
						Array.Reverse (stringsArray);
						string sep = ".";
						string reversedString = string.Join (sep, stringsArray);
						Console.WriteLine ("reversed string is:{0}",reversedString);
			
						//writing the reversed text to a new file
			
						string newFilePath=@"C:\Users\Public\TestFolder\newfile.txt";
						System.IO.File.WriteAllText (newFilePath, reversedString);


		}
	}
}
	