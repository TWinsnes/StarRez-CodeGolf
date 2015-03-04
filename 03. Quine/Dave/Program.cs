using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quine
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			string[] str = {
"using System;",
"using System.Collections.Generic;",
"using System.Linq;",
"using System.Text;",
"",
"namespace Quine",
"{",
"	internal class Program",
"	{",
"		public static void Main(string[] args)",
"		{",
"			string[] str = {",
"			};",
"			StringBuilder sb = new StringBuilder();",
"			for (int i = 0; i < 12; i++) sb.AppendLine(str[i]);",
"			for (int i = 0; i < str.Length; i++) sb.AppendLine((char)34 + str[i] + (char)34 + ',');",
"			for (int i = 12; i < str.Length; i++) sb.AppendLine(str[i]);",
"			string input = sb.Remove(sb.Length - 2, 2).ToString();",
"			char[] sample = input.Distinct().ToArray();",
"			Random rand = new Random();",
"			string attempt = string.Concat(Enumerable.Range(0, input.Length).Select(e => sample[rand.Next(0, sample.Length)]));",
"",
"			while (true)",
"			{",
"				if (attempt.Equals(input, StringComparison.Ordinal))",
"				{",
"					Console.Write(attempt);",
"					return;",
"				}",
"				List<string> children = new List<string>(50);",
"				for (int i = 0; i < 50; i++)",
"				{",
"					StringBuilder mutation = new StringBuilder(attempt);",
"					for (int j = 0; j < 50; j++)",
"					{",
"						int index = rand.Next(0, attempt.Length);",
"						if (mutation[index] != input[index])",
"						{",
"							mutation[index] = sample[rand.Next(0, sample.Length)];",
"						}",
"					}",
"					children.Add(mutation.ToString());",
"				}",
"				Comp cmp = new Comp();",
"				attempt = children.OrderBy(c => cmp.Compare(c, input)).First();",
"			}",
"		}",
"	}",
"",
"	public class Comp : Comparer<string>",
"	{",
"		public override int Compare(string s, string t)",
"		{",
"			int result = 0;",
"			for (int x = 0; x < s.Length; x++)",
"			{",
"				int difference = Math.Abs(s[x] - t[x]);",
"				result += difference;",
"			}",
"			return result;",
"		}",
"	}",
"}",
			};
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < 12; i++) sb.AppendLine(str[i]);
			for (int i = 0; i < str.Length; i++) sb.AppendLine((char)34 + str[i] + (char)34 + ',');
			for (int i = 12; i < str.Length; i++) sb.AppendLine(str[i]);
			string input = sb.Remove(sb.Length - 2, 2).ToString();
			char[] sample = input.Distinct().ToArray();
			Random rand = new Random();
			string attempt = string.Concat(Enumerable.Range(0, input.Length).Select(e => sample[rand.Next(0, sample.Length)]));

			while (true)
			{
				if (attempt.Equals(input, StringComparison.Ordinal))
				{
					Console.Write(attempt);
					return;
				}
				List<string> children = new List<string>(50);
				for (int i = 0; i < 50; i++)
				{
					StringBuilder mutation = new StringBuilder(attempt);
					for (int j = 0; j < 50; j++)
					{
						int index = rand.Next(0, attempt.Length);
						if (mutation[index] != input[index])
						{
							mutation[index] = sample[rand.Next(0, sample.Length)];
						}
					}
					children.Add(mutation.ToString());
				}
				Comp cmp = new Comp();
				attempt = children.OrderBy(c => cmp.Compare(c, input)).First();
			}
		}
	}

	public class Comp : Comparer<string>
	{
		public override int Compare(string s, string t)
		{
			int result = 0;
			for (int x = 0; x < s.Length; x++)
			{
				int difference = Math.Abs(s[x] - t[x]);
				result += difference;
			}
			return result;
		}
	}
}