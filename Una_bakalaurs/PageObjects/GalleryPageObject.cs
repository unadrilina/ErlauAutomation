using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Una_bakalaurs.Utils;

namespace Una_bakalaurs.PageObjects
{
    class GalleryPageObject
    {
        Driver _driver;
        public GalleryPageObject(Driver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".fl-node-5991bca5c6bbd>div>div>div>div>div>a")]
        public IList<IWebElement> GalleryImgList { get; set; } // List of result Images


        [FindsBy(How = How.XPath, Using = "//*[contains(@id,'ngg-webslice')]/h2")]
        [CacheLookup]
        public IWebElement GalleryTitle { get; set; }
        public string GalleryTitleText => GalleryTitle.Text;
    }
}
