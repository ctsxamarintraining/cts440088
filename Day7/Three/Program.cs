using System;
using System.Globalization;
namespace Three
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			string str=@"the return of sherlock holmes";
			string resultString=str.convertToTitleCaseMethod();
			Console.WriteLine (resultString);

		}

	}
	public static class extensionClass
	{
		public static string convertToTitleCaseMethod(this string s)
		{
			TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
			return ti.ToTitleCase (s);
		}
	}

}
	