using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instructor_Cookiecookbook.DataAccess
{
    public abstract class StringsRepository : IStringsRepository
    {
        public List<string> Read(string filePath)
        {
            if (!File.Exists(filePath)) return new List<string>();
            var fileContents = File.ReadAllText(filePath);
            return TextToStrings(fileContents);
        }

        protected abstract List<string> TextToStrings(string fileContents);

        public void Write(string filePath, List<string> strings)
        {
            File.WriteAllText(filePath, StringsToText(strings));
        }

        protected abstract string? StringsToText(List<string> strings);
    }
}

