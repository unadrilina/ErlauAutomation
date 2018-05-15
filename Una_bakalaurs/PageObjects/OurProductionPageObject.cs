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
    class OurProductionPageObject
    {
        Driver _driver;
        public OurProductionPageObject(Driver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".fl-node-577e42ecbf11c>div>div>p>span>strong>span")]
        [CacheLookup]
        public IWebElement OurProductionTitle_field { get; set; }
        public string OurProductionTitle_fieldText => OurProductionTitle_field.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-576949fd75629>div>h2")]
        [CacheLookup]
        public IWebElement SoliTitle_field { get; set; }
        public string SoliTitle_fieldText => SoliTitle_field.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-57694c363794e>div>h2")]
        [CacheLookup]
        public IWebElement SoluSistemaTitle_field { get; set; }
        public string SoluSistemaTitle_fieldText => SoluSistemaTitle_field.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-5773d6934e20c>div>div>p>span")]
        [CacheLookup]
        public IWebElement SoluGalduKombinacijaTitle_field { get; set; }
        public string SoluGalduKombinacijaTitle_fieldText => SoluGalduKombinacijaTitle_field.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-5774fc9f83c06>div>h2")]
        [CacheLookup]
        public IWebElement GaldiTitle_field { get; set; }
        public string GaldiTitle_fieldText => GaldiTitle_field.Text;


        [FindsBy(How = How.CssSelector, Using = ".fl-node-5774fd2e44503>div>h2")]
        [CacheLookup]
        public IWebElement SaulosanasKresli_field { get; set; }
        public string SaulosanasKresli_fieldText => SaulosanasKresli_field.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-577501c0e0e76>div>h2")]
        [CacheLookup]
        public IWebElement AtkritumuKonteineri_field { get; set; }
        public string AtkritumuKonteineri_fieldText => AtkritumuKonteineri_field.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-57751cec28a72>div>h2")]
        [CacheLookup]
        public IWebElement VelosipeduNovietne_field { get; set; }
        public string VelosipeduNovietne_fieldText => VelosipeduNovietne_field.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-577e1d8d53dbe>div>div>p>span")]
        [CacheLookup]
        public IWebElement AprikojumsFitenesam_field { get; set; }
        public string AprikojumsFitenesam_fieldText => AprikojumsFitenesam_field.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-57614f10bd995>div>h2")]
        [CacheLookup]
        public IWebElement KonfiguaratorsSoluSist_field { get; set; }
        public string KonfiguaratorsSoluSist_fieldText => KonfiguaratorsSoluSist_field.Text;

        [FindsBy(How = How.ClassName, Using = "fl-html")]
        [CacheLookup]
        public IWebElement KonfiguaratorsGalduSistImg_field { get; set; }

        [FindsBy(How = How.ClassName, Using = "fl-html")]
        [CacheLookup]
        public IWebElement KonfiguaratorsSolsImg_field { get; set; }

        [FindsBy(How = How.ClassName, Using = "entry-title")]
        [CacheLookup]
        public IWebElement TermsOfUseTitle_field { get; set; }
        public string TermsOfUseTitle_fieldText => TermsOfUseTitle_field.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-photo-content>a")]
        public IList<IWebElement> OurProductionImgList { get; set; } // List of result Images

        [FindsBy(How = How.XPath, Using = "(//*[contains(@class, 'fl-rich-text')]/p/span/a)[1]")]
        [CacheLookup]
        public IWebElement OurProduction_First_field { get; set; }
        public string OurProduction_First_fieldText => OurProduction_First_field.Text;

        [FindsBy(How = How.XPath, Using = "(//*[contains(@class, 'fl-rich-text')]/p/span/a)[2]")]
        [CacheLookup]
        public IWebElement OurProduction_Second_field { get; set; }
        public string OurProduction_Second_fieldText => OurProduction_Second_field.Text;

        [FindsBy(How = How.XPath, Using = "(//*[contains(@class, 'fl-rich-text')]/p/span/a)[3]")]
        [CacheLookup]
        public IWebElement OurProduction_Thirdth_field { get; set; }
        public string OurProduction_Thirdth_fieldText => OurProduction_Thirdth_field.Text;

        [FindsBy(How = How.XPath, Using = "(//*[contains(@class, 'fl-rich-text')]/p/span/a)[4]")]
        [CacheLookup]
        public IWebElement OurProduction_Fourth_field { get; set; }
        public string OurProduction_Fourth_fieldText => OurProduction_Fourth_field.Text;

        [FindsBy(How = How.XPath, Using = "(//*[contains(@class, 'fl-rich-text')]/p/span/a)[5]")]
        [CacheLookup]
        public IWebElement OurProduction_Fifth_field { get; set; }
        public string OurProduction_Fifth_fieldText => OurProduction_Fifth_field.Text;

        [FindsBy(How = How.XPath, Using = "(//*[contains(@class, 'fl-rich-text')]/p/span/a)[6]")]
        [CacheLookup]
        public IWebElement OurProduction_Sixth_field { get; set; }
        public string OurProduction_Sixth_fieldText => OurProduction_Sixth_field.Text;

        [FindsBy(How = How.XPath, Using = "(//*[contains(@class, 'fl-rich-text')]/p/span/a)[7]")]
        [CacheLookup]
        public IWebElement OurProduction_Seventh_field { get; set; }
        public string OurProduction_Seventh_fieldText => OurProduction_Seventh_field.Text;

        [FindsBy(How = How.XPath, Using = "(//*[contains(@class, 'fl-rich-text')]/p/span/a)[8]")]
        [CacheLookup]
        public IWebElement OurProduction_Eight_field { get; set; }
        public string OurProduction_Eight_fieldText => OurProduction_Eight_field.Text;
    }
}
