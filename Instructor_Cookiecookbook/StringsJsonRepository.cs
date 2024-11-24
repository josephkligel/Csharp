using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Instructor_Cookiecookbook
{
	public class StringsJsonRepository: IStringsRepository
	{ 
		public List<string> Read(string filePath)
		{
			if (!File.Exists(filePath)) return new List<string>();
			var fileContents = File.ReadAllText(filePath);
			return JsonSerializer.Deserialize<List<string>>(fileContents);
		}

		public void Write(string filePath, List<string> strings)
		{
			File.WriteAllText(filePath, JsonSerializer.Serialize(strings));
		}
	}
}
