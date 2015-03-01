using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
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

namespace IMXLogin.Tests
{
    class Asserts
    {
        [FindBy]
        private static void isLoginSuccessful(string[] fields, IWebDriver driver)
        {
            if (fields[3] == "No")
            {
                IWebElement invalidlogin = driver.FindElement(By.CssSelector(".text-danger"));

                Assert.True(invalidlogin.Displayed);
            }

            else if (fields[3] == "Yes")
            {
                IWebElement validlogin = driver.FindElement(By.CssSelector("[href=\"#Logout\"]"));

                Assert.True(validlogin.Displayed);
            }
        }
    }
}
