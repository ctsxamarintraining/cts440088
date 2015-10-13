//using System;
//
//namespace ExceptionsTask2
//{
//	class MainClass
//	{
//		public static void Main (string[] args)
//		{
//			Console.WriteLine ("Enter number:");
//			string s=Console.ReadLine ();
//			try{
//				int i=Int32.Parse(s);
//				if(i<0)
//					throw new ApplicationException("Negative number entered..!!");
//				Console.WriteLine("{0}",Math.Sqrt(i));
//			}
//			catch(Exception e) {
//				Console.WriteLine ("Invalid number and the exception was:{0}",e);
//			}
//			finally
//			{
//				Console.WriteLine ("Good Bye");
//			}
//		}
//	}
//}


