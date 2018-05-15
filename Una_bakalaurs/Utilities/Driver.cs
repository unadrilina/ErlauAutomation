using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;


namespace Una_bakalaurs.Utils
{

    public class Driver
    {
        public IWebDriver driver;
        public static WebDriverWait Wait;

        public Driver()
        {
            driver = new ChromeDriver();    
           
        }
        public void CloseWebDriver()
        {
            driver.Quit();
        }

        public void MaximizeWindow()
        {
            driver.Manage().Window.Maximize();
        }

        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
            
        }
        public void SetTimeout(int seconds)
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
        }
    }
}
