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
    class ConfiguratorPageObject
    {
        Driver _driver;
        public ConfiguratorPageObject(Driver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".fl-node-57690b7b00570>div>div>p>span>strong>span")]
        [CacheLookup]
        public IWebElement ConfiguratorTitleField { get; set; }
        public string ConfiguratorTitleFieldText => ConfiguratorTitleField.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-photo-img")]
        public IList<IWebElement> ConfiguratorImgList { get; set; } // List of result Images

        [FindsBy(How = How.CssSelector, Using = ".fl-node-574da995894a7>div>div>p>span>strong>span>a")]
        [CacheLookup]
        public IWebElement ConfiguratorSolsField { get; set; }
        public string ConfiguratorSolsFieldText => ConfiguratorSolsField.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-574daa0fe1076>div>div>p>span>strong>span>a")]
        [CacheLookup]
        public IWebElement ConfiguratorSoluSistemaField { get; set; }
        public string ConfiguratorSoluSistemaFieldText => ConfiguratorSoluSistemaField.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-574da9e5318d8>div>div>p>span>strong>a")]
        [CacheLookup]
        public IWebElement ConfiguratorSoluGalduKombinacijaField { get; set; }
        public string ConfiguratorSoluGalduKombinacijaFieldText => ConfiguratorSoluGalduKombinacijaField.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-57614dacb4eeb>div>h2")]
        [CacheLookup]
        public IWebElement ConfiguratorSoluTitleField { get; set; }
        public string ConfiguratorSoluTitleFieldText => ConfiguratorSoluTitleField.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-57614f10bd995>div>h2")]
        [CacheLookup]
        public IWebElement ConfiguratorSoluSistemaTitleField { get; set; }
        public string ConfiguratorSoluSistemaTitleFieldText => ConfiguratorSoluSistemaTitleField.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-56faa48d98968>div>div>p>span")]
        [CacheLookup]
        public IWebElement ConfiguratorSecondaryTitleField { get; set; }
        public string ConfiguratorSecondaryTitleFieldText => ConfiguratorSecondaryTitleField.Text;


    }
}
