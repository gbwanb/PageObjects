using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace IMXLogin.Generators
{
    public class UserGenerator
    {
        static string[] fields = ReadFile.parser.ReadFields();

        public static string readUsername()
        {
            String username = fields[1];
            return username;
        }
    }
}
