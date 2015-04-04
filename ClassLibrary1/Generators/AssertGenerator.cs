using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMX.Pages
{
    class AssertGenerator
    {
        static string[] fields = ReadFile.parser.ReadFields();

        public static string readAssert()
        {
            String isValid = fields[3];
            return  isValid;
        }
    }
}
