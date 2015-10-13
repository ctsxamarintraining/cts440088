//using System;
//using System.IO;
//using System.Text;
//
//class Test 
//{
//	public static void Main() 
//	{
//		Console.WriteLine ("Enter the location");
//		string s = Console.ReadLine ();
//		try{
//			
//			string[] lines = System.IO.File.ReadAllLines(s);
//
//			System.Console.WriteLine("Contents are: ");
//			foreach (string line in lines)
//			{
//				Console.WriteLine("\n" + line);
//			}
//
//		}
//
//		catch(FileNotFoundException e) {
//			Console.WriteLine ("File not found at that location");
//			//Console.WriteLine (e);
//		}
//		catch(FileLoadException e) {
//			Console.WriteLine ("File couldnt be loaded but found");
//			//Console.WriteLine (e);
//		}
//		catch(Exception e) {
//			Console.WriteLine (e);
//		}
//	}
//}