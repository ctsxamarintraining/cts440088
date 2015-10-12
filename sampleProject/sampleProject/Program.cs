using System;

namespace sampleProject
{
	class MainClass
	{
		static int k = 0;
		public static void Main (string[] args)
		{
			int[] sampleArray=new int[10];

			do{
			Console.WriteLine("enter number:");
			string readData=Console.ReadLine();
			try{

				int i=Int32.Parse(readData);
				sampleArray[k]=i;
				k++;  
								for(int a=0;a<k;a++)
								{
						Console.Write("{0},",sampleArray[a]);
								}
					Console.WriteLine();
			}
			catch(IndexOutOfRangeException e) { 
				Console.WriteLine (e.Message);
			}
			catch(FormatException e) {
				Console.WriteLine (e.Message);
			}
			catch(Exception e) {
				Console.WriteLine (e.Message);
			}
			finally
			{

			}
			}while(true);
		}

	}
}
