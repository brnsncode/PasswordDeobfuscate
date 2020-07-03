using System;

public class Program
{
	public static void Main()
	{
		string obfuscatedPass = "|9Aj|ehVUMVZ|1RaZ1V|6h|2|VNVlVq|J1VKd|kY1|UVV|ZhlUX1|kTSRk|W3llRjNEaw|UFc4d0VVh2aU|lXS|yE2V|0JjV|";
		Console.WriteLine(String.Format("pw to deobfuscate: {0}", obfuscatedPass));
		string deobfuscatedPass = Deobfuscate(obfuscatedPass);
		Console.WriteLine(String.Format("reversing pw: {0}", deobfuscatedPass));
		Console.WriteLine("sanitizing pw...");
		string _ = "";
		string sanitized = "";
		for (int i = 0; i <= 1; i++)
		{
			if (i % 2 == 0)
			{
				_ += System.Convert.ToString(deobfuscatedPass[i]);
				foreach (var chars in deobfuscatedPass.Split(_[0]))
				{
					sanitized += chars;
					Console.WriteLine(String.Format("Sanitization step {0}: {1}", i++, sanitized));
				}
			}
		}

		Console.WriteLine(String.Format("sanitization complete: {0}", sanitized));
		Console.WriteLine(String.Format("Decoding pw: {0}", sanitized));
		string decode = b64decode(sanitized);
		Console.WriteLine(String.Format("password found: {0}", decode));
	}

	public static string Deobfuscate(string str)
	{
		char[] arr = str.ToCharArray();
		Array.Reverse(arr);
		return new string (arr);
	}

	public static string b64decode(string pass)
	{
		for (int i = 0; i < 5; i++)
		{
			byte[] data = System.Convert.FromBase64String(pass);
			pass = System.Text.Encoding.ASCII.GetString(data);
			Console.WriteLine(pass);
		}

		return pass;
	}
}
