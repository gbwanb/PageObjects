using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace IMX.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;

        public string username = UserGenerator.readUsername();
        public string password = PasswordGenerator.readPassword();

        public LoginPage(IWebDriver driver)
        { this.driver = driver;
        
        if (driver.Title != "Admin Web")
            throw new NoSuchWindowException("This is not the Login page");
        }
        //FirefoxDriver driver = new FirefoxDriver();

        
        public SearchPage Do(string username, string password)


        {
            driver.FindElement(By.CssSelector("#UserName")).SendKeys(username);
            driver.FindElement(By.CssSelector("#Password")).SendKeys(password);
            driver.FindElement(By.CssSelector(".btn")).Click();

            return new SearchPage(driver);
        }
    }
}
