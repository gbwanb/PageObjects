using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMX.Pages
{
    class PasswordGenerator
    {
        static string[] fields = ReadFile.parser.ReadFields();

        public static string readPassword()
        {
            String password = fields[2];
            return password;
        }
    }
}
