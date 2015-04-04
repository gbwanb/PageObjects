using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using Microsoft.VisualBasic.FileIO;

namespace IMX.Pages
{
    class ReadFile
    {
        public static TextFieldParser parser = new TextFieldParser(@"c:\temp\test.csv");

        

        //string[] fields = parser.ReadFields();

        public static SearchPage readLoginDetailsFromCsv()
        {
            //using (TextFieldParser parser = new TextFieldParser(@"c:\temp\test.csv"))
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            while (!parser.EndOfData)
            {
                //Processing row
                string[] fields = parser.ReadFields();
                foreach (string field in fields)
                {
                    string username = fields[1];
                    string password = fields[2];
                    string valid = fields[3];

                     IWebDriver driver = new FirefoxDriver();
                        
            driver.Navigate().GoToUrl("https://gtsmobile.imxclient.com/IMXMobileWeb");

            LoginPage Login = new LoginPage(driver);

            SearchPage ConfirmOnSearchPage = Login.Do(username, password);

            return ConfirmOnSearchPage;

  


                    //UserGenerator.readUsername();
                    //PasswordGenerator.readPassword();
                    //AssertGenerator.readAssert();
                }
               

            }
            return null;
        }
    }

}


