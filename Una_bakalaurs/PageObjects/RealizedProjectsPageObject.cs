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
    class RealizedProjectsPageObject
    {
        Driver _driver;
        public RealizedProjectsPageObject(Driver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".fl-node-577e44f221d64>div>div>p>span>strong")]
        [CacheLookup]
        public IWebElement ProjectsTitle { get; set; }
        public string ProjectsTitleText => ProjectsTitle.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-57601f95197a3>div>h2")]
        [CacheLookup]
        public IWebElement ProjectsSecondaryTitle { get; set; }
        public string ProjectsSecondaryTitleText => ProjectsSecondaryTitle.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-577e232579039>div>div>p")]
        [CacheLookup]
        public IWebElement ProjectsThirdthTitle { get; set; }
        public string ProjectsThirdthTitleText => ProjectsThirdthTitle.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-photo-img")]
        public IList<IWebElement> ProjectsImgList { get; set; } // List of result Images

        [FindsBy(How = How.CssSelector, Using = ".fl-node-576016634a9ec>div>div>p")]
        [CacheLookup]
        public IWebElement ProjectsFirstReason { get; set; }
        public string ProjectsFirstReasonText => ProjectsFirstReason.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-5760166a09e53>div>div>p")]
        [CacheLookup]
        public IWebElement ProjectsSecondReason { get; set; }
        public string ProjectsSecondReasonText => ProjectsSecondReason.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-5760167023758>div>div>p")]
        [CacheLookup]
        public IWebElement ProjectsThirdReason { get; set; }
        public string ProjectsThirdReasonText => ProjectsThirdReason.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-57601676e089b>div>div>p")]
        [CacheLookup]
        public IWebElement ProjectsFourthReason { get; set; }
        public string ProjectsFourthReasonText => ProjectsFourthReason.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-5760167cd8745>div>div>p")]
        [CacheLookup]
        public IWebElement ProjectsFivethReason { get; set; }
        public string ProjectsFivethReasonText => ProjectsFivethReason.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-57601656b4ef4>div>div>p")]
        [CacheLookup]
        public IWebElement ProjectsSixthReason { get; set; }
        public string ProjectsSixthReasonText => ProjectsSixthReason.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-57601ca5707a1>div>div>p")]
        [CacheLookup]
        public IWebElement ProjectsFirstPlace { get; set; }
        public string ProjectsFirstPlaceText => ProjectsFirstPlace.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-57601cb5997a1>div>div>p")]
        [CacheLookup]
        public IWebElement ProjectsSecondPlace { get; set; }
        public string ProjectsSecondPlaceText => ProjectsSecondPlace.Text;

    }
}
