using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instructor_Cookiecookbook.DataAccess
{
    public class StringsTextualRepository : StringsRepository
    {
        private string Seperator = ",";

        protected override List<string> TextToStrings(string fileContents)
        {
            return fileContents.Split(Seperator).ToList();
        }

        protected override string? StringsToText(List<string> strings)
        {
            return string.Join(Seperator, strings);
        }
    }
}
