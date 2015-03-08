using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMX.Pages
{
    class SearchPage
    {
        private IWebDriver driver;

        public SearchPage(IWebDriver driver)
        {
            this.driver = driver;
            Boolean isPresent = driver.FindElement(By.CssSelector("#btnFTPOutputFile")).Size > 0;
            if (isPresent == false)
                throw new NoSuchElementException("This is not the Search page");
        }

        public void Do()
        {
            Console.WriteLine("On the Search page");
        }

        public LoginPage Logout()
        {
            driver.FindElement(By.CssSelector("a[href=\"#Logout\"]")).Click();

            return new LoginPage(driver);
        }
    }
}
