using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using IMXLogin.Generators;

namespace IMXLogin.Pages
{
    class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        { this.driver = driver;
        
        if (driver.Title != "Admin Web")
            throw new NoSuchWindowException("This is not the Login page");
        }
        //FirefoxDriver driver = new FirefoxDriver();
        public string username = UserGenerator.readUsername();
        public string password = PasswordGenerator.readPassword();
        
        public SearchPage Do(string username, string password)
        {
            IWebElement element1 = driver.FindElement(By.CssSelector("#UserName"));
            element1.SendKeys(username);
            IWebElement element2 = driver.FindElement(By.CssSelector("#Password"));
            element2.SendKeys(password);
            IWebElement loginbutton = driver.FindElement(By.CssSelector(".btn"));
            loginbutton.Click();

            return new SearchPage(driver);
        }
    }
}
