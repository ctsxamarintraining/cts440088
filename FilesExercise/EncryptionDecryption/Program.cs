using System;
using System.IO;
using System.Security.Cryptography;

namespace EncryptionDecryption
{
	class MainClass
	{
		public static void Main (string[] args)
				{
					//reading text from console
					Console.WriteLine ("enter a string");
					string str = Console.ReadLine ();
		
					//Writing encoded text to a new file
					string encodedString = str.encrypt ();
					string filepath=@"C:\Users\Public\TestFolder\text.txt";
					System.IO.File.WriteAllText(filepath, encodedString);
		
					//displaying the decoded text in the console
					string readText = File.ReadAllText(filepath);
					string decodedText = readText.Decrypt ();
					Console.WriteLine ("encoded text is:{0}",readText);
					Console.WriteLine ("decoded text is:{0}",decodedText);
		
				}
	}

		public static class extensionClass{
	
			public static byte[] key = new byte[8] {1, 2, 3, 4, 5, 6, 7, 8};
			public static byte[] iv = new byte[8] {1, 2, 3, 4, 5, 6, 7, 8};

			public static string encrypt(this string text)
			{
				SymmetricAlgorithm algorithm = DES.Create();
				ICryptoTransform transform = algorithm.CreateEncryptor(key, iv);
				byte[] inputbuffer = System.Text.Encoding.Unicode.GetBytes(text);
				byte[] outputBuffer = transform.TransformFinalBlock(inputbuffer, 0, inputbuffer.Length);
				return Convert.ToBase64String(outputBuffer);
			}
	
			public static string Decrypt(this string text)
			{
				SymmetricAlgorithm algorithm = DES.Create();
				ICryptoTransform transform = algorithm.CreateDecryptor(key, iv);
				byte[] inputbuffer = Convert.FromBase64String(text);
				byte[] outputBuffer = transform.TransformFinalBlock(inputbuffer, 0, inputbuffer.Length);
				return System.Text.Encoding.Unicode.GetString(outputBuffer);
			}
		}
}

