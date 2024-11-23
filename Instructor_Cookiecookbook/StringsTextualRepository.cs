using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instructor_Cookiecookbook
{
	public class StringsTextualRepository : IStringsRepository
	{
		private static readonly string seperator = Environment.NewLine;

		public List<string> Read(string filePath)
		{
			if (!File.Exists(filePath)) return new List<string>();
			var fileContents = File.ReadAllText(filePath);
			return fileContents.Split(seperator).ToList();
		}

		public void Write(string filePath, List<string> strings)
		{
			File.WriteAllText(filePath, string.Join(seperator, strings));
		}
	}
}
