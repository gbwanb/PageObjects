using Microsoft.VisualBasic.FileIO;

namespace IMXLogin.Generators
{
    class ReadFile
    {
        public static TextFieldParser parser = new TextFieldParser(@"c:\temp\test.csv");
        //string[] fields = parser.ReadFields();

        public void readLoginDetailsFromCsv()
        {
            //using (TextFieldParser parser = new TextFieldParser(@"c:\temp\test.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    //Processing row
                    //string[] fields = parser.ReadFields();
                    //foreach (string field in fields)
                    {
                        //String username = fields[1];
                        //String password = fields[2];
                        //String valid = fields[3];
                    }
                }
            }
        }
    }
}
