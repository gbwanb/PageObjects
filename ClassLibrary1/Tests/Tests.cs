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
    [TestFixture]
    public class Class1
    {
        [Test]
        public void loginToImxMobileWeb()
        {
            ReadFile.readLoginDetailsFromCsv();

            if (ReadFile.readLoginDetailsFromCsv() != null)
            {
                Assert.True(AssertGenerator.readAssert() == "Yes");
            }
            else
            {
                Assert.True(AssertGenerator.readAssert() == "No");
            }
                        /*IWebElement element1 = driver.FindElement(By.CssSelector("#UserName"));
                        element1.SendKeys(username);
                        IWebElement element2 = driver.FindElement(By.CssSelector("#Password"));
                        element2.SendKeys(password);
                        IWebElement loginbutton = driver.FindElement(By.CssSelector(".btn"));
                        loginbutton.Click();

                        isLoginSuccessful(fields, driver);*/
           // Login = ConfirmOnSearchPage.Logout();

        //    driver.Close();
            }

       }
}

