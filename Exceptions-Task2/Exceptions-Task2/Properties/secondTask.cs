using System;
using System.IO;

namespace ExceptionsThree
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//string path = "";

			Console.WriteLine ("Enter the location");
			string s = Console.ReadLine ();

			try{
				string readText = File.ReadAllText(s);
				Console.WriteLine(readText);
//
//
//				string[] lines = System.IO.File.ReadAllLines(s);
//
//				System.Console.WriteLine("Contents are: ");
//				foreach (string line in lines)
//				{
//					Console.WriteLine("\n" + line);
//				}


			}
			catch(ArgumentNullException e)
			{
				Console.WriteLine ("Path cannot be null");
				Console.WriteLine (e.Message);
			}
			catch(ArgumentException e)
			{
				Console.WriteLine ("Enter a Path");
				Console.WriteLine (e.Message);
			}
			catch(PathTooLongException e)
			{
				Console.WriteLine ("Path is too long");
				Console.WriteLine (e.Message);
			}
			catch(DirectoryNotFoundException e) 
			{
				Console.WriteLine ("Directory Not Found");
				Console.WriteLine (e.Message);
			}
			catch(FileNotFoundException e) 
			{
				Console.WriteLine ("Could not find the file at the given path");
				Console.WriteLine (e.Message);
			}
			catch(IOException e) 
			{
				Console.WriteLine (e.Message);
			}

			catch(UnauthorizedAccessException e)
			{
				Console.WriteLine (e.Message);
			}

			catch(NotSupportedException e) 
			{
				Console.WriteLine ("path is in an invalid format");
				Console.WriteLine (e.Message);
			}
			catch(FileLoadException e) {
						Console.WriteLine ("File couldnt be loaded but found");
						//Console.WriteLine (e);
					}
			catch(Exception e) {
						Console.WriteLine (e);
					}
			finally 
			{
				Console.WriteLine ("final block");
			}
		}
	}
}