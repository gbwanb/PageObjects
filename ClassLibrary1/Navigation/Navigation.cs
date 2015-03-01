using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

namespace IMXLogin.Navigation
{
    class Navigation
    {
        IWebDriver driver =  new FirefoxDriver();
         
        public void goToPage(string url)
        { 
            driver.Navigate().GoToUrl(url);
        }
    }
}
