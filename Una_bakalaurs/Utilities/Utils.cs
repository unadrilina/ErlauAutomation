using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Una_bakalaurs.Utils
{
    public static class Utils
    {
        public static void WaitForElementPresent(this IWebElement element, Driver _driver)
        {
            _driver.SetTimeout(0);
            Driver.Wait.Until(driver => element.Displayed);
            _driver.SetTimeout(Constants.Timeout);
        }
  

        public static void MoveToElement(IWebElement element, IWebDriver driver)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }
        public static void WaitForElementWithSpecificText(this IWebElement element, string title, Driver _driver)
        {
            _driver.SetTimeout(0);
            int waitTime = 60;
            string status = "";
            DateTime currentTime = DateTime.Now;

            while ((DateTime.Now - currentTime).TotalSeconds <= waitTime && !status.Contains(title))
            {
                try
                {
                    Driver.Wait.Until(driver => element.Displayed);
                    IWebElement txtStatus = element;
                    status = txtStatus.Text;
                    Console.WriteLine(status);
                }
                catch
                {
                    Debug.WriteLine("Element with specific text not found");
                    break;
                }
            }
            _driver.SetTimeout(Constants.Timeout);
        }
        public static void SelectTheDropdownValue(this IWebElement select, string value)
        {
            new SelectElement(select).SelectByText(value);
        }

        private static bool IsElementVisible(IWebElement element)
        {
            return element.Displayed && element.Enabled;
        }

        public static bool CheckIfElementExist(IList<IWebElement> products)
        {
            return (products.Count >= 1) ? true : false;
        }
        public static void checkIfElementIsNotStaleAndClick(this IWebElement element)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            bool isElementNotStale = false;

            while (timer.Elapsed < TimeSpan.FromSeconds(Constants.Timeout) && (!isElementNotStale))
            {
                try
                {
                    element.Click();
                    isElementNotStale = true;
                    Console.WriteLine("ELEMENT IS CLICKABLE");
                }
                catch
                {
                    Console.WriteLine("ELEMENT IS NOT CLICKABLE");
                    Thread.Sleep(250);
                }
            }
        }
        public static void checkIfElementIsNotStaleAndEnterValue(this IWebElement element, string value)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            bool isElementNotStale = false;

            while (timer.Elapsed < TimeSpan.FromSeconds(Constants.Timeout) && (!isElementNotStale))
            {
                try
                {
                    element.SendKeys(value);
                    isElementNotStale = true;
                    Console.WriteLine("ELEMENT IS CLICKABLE");
                }
                catch
                {
                    Console.WriteLine("ELEMENT IS NOT CLICKABLE");
                    Thread.Sleep(250);
                }
            }
        }
        public static void WaitUntilVisible(this IWebElement element)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            while (timer.Elapsed < TimeSpan.FromSeconds(Constants.Timeout))
            {
                if (element.GetCssValue("visibility").Contains("visible")) break;
            }
        }
        public static void waitForElementNotPresent(this IWebElement element, Driver _driver)
        {
            _driver.SetTimeout(0);
            int waitTime = 120;
            DateTime currentTime = DateTime.Now;

            while ((DateTime.Now - currentTime).TotalSeconds <= waitTime)
            {
                try
                {
                    if (element.Displayed)
                    {
                        Debug.WriteLine("Element is Displayed ");
                        Thread.Sleep(10000);
                    }
                }
                catch (NoSuchElementException)
                {
                    Debug.WriteLine("Element was NOT found ");
                    break;
                }
                catch (StaleElementReferenceException)
                {
                    Debug.WriteLine("Element was NOT found ");
                    break;
                }
            }
            _driver.SetTimeout(Constants.TimeoutApp);
        }

        public static void HoverAndClickElement(this IWebElement element, IWebDriver driver)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
        }
    }
}
