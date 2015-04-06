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
    class LoginPage
    {
        private IWebDriver driver;
        //public static TextFieldParser parser = new TextFieldParser(@"c:\temp\test.csv");
        

        //public string username = UserGenerator.readUsername();
        //public string password = PasswordGenerator.readPassword();

        public LoginPage(IWebDriver driver)
        { this.driver = driver;
        
        if (driver.Title != "Admin Web")
            throw new NoSuchWindowException("This is not the Login page");
        }

        By usernameLocator = By.CssSelector("#UserName");
        By passwordLocator = By.CssSelector("#Password");
        By loginButtonLocator = By.CssSelector(".btn");
        //FirefoxDriver driver = new FirefoxDriver();

       
        // This is the only place that "knows" how to enter a username


        public LoginPage typeUsername(String username) {
            driver.FindElement(usernameLocator).SendKeys(username);
            return this;
        }

        public LoginPage typePassword(String password) {
            driver.FindElement(passwordLocator).SendKeys(password);
            return this;
        }

        public SearchPage clickLogin() {
            driver.FindElement(loginButtonLocator).Click();
            return new SearchPage(driver);    
        }
        
        public SearchPage Do(TextFieldParser fileLocation)
        {
            //public static TextFieldParser parser = new TextFieldParser(@"fileLocation");
            TextFieldParser parser = new TextFieldParser(@"c:\temp\test.csv");
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            while (!parser.EndOfData)
            {
                //Processing row
                string[] fields = parser.ReadFields();
                //foreach (string field in fields)
                {
                    string username = fields[1];
                    string password = fields[2];
                    string valid = fields[3];

                    typeUsername(username);
                    typePassword(password);
                    clickLogin();
                    {
                        break;
                    }
                }
            }
        }
}
 

        

        //string[] fields = parser.ReadFields();

        public static SearchPage readLoginDetailsFromCsv()
        {
           

                     IWebDriver driver = new FirefoxDriver();
                        
            driver.Navigate().GoToUrl("https://gtsmobile.imxclient.com/IMXMobileWeb");

            LoginPage Login = new LoginPage(driver);

            SearchPage ConfirmOnSearchPage = Login.Do(username, password);

            return ConfirmOnSearchPage;