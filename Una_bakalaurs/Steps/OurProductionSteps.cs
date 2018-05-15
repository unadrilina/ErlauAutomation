using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Una_bakalaurs.PageObjects;
using Una_bakalaurs.Utils;

namespace Una_bakalaurs.Steps
{
    [Binding]
    class OurProductionSteps
    {
        OurProductionPageObject OurProduction;
        HomePageObject HomePage;
        public Driver _driver;
        public OurProductionSteps(Driver driver)
        {
            _driver = driver;
            OurProduction = new OurProductionPageObject(driver);
            HomePage = new HomePageObject(driver);
        }

        [When(@"I navigate to OurProduction page")]
        public void WhenINavigateToOurProductionPage()
        {
            HomePage.Navigation_MusuProdukcija.WaitUntilVisible();
            HomePage.Navigation_MusuProdukcija.Click();
        }

        [Then(@"I see ""(.*)"" image are present on OurProduction page")]
        public void ThenISeeImgageArePresentOnOurProductionPage(int imgCount)
        {
            Assert.AreEqual(imgCount, OurProduction.OurProductionImgList.Count);
        }

        [Then(@"I see the first OurProduction element is ""(.*)""")]
        public void ThenISeeTheFirstOurProductionElementIs(string first)
        {
            OurProduction.OurProduction_First_field.WaitUntilVisible();
            Assert.AreEqual(first, OurProduction.OurProduction_First_fieldText);
        }

        [Then(@"I see the second OurProduction element is ""(.*)""")]
        public void ThenISeeTheSecondOurProductionElementIs(string second)
        {
            OurProduction.OurProduction_Second_field.WaitUntilVisible();
            Assert.AreEqual(second, OurProduction.OurProduction_Second_fieldText);
        }

        [Then(@"I see the third OurProduction element is ""(.*)""")]
        public void ThenISeeTheThirdOurProductionElementIs(string third)
        {
            OurProduction.OurProduction_Thirdth_field.WaitUntilVisible();
            Assert.AreEqual(third, OurProduction.OurProduction_Thirdth_fieldText);
        }

        [Then(@"I see the fourth OurProduction element is ""(.*)""")]
        public void ThenISeeTheFourthOurProductionElementIs(string fourth)
        {
            OurProduction.OurProduction_Fourth_field.WaitUntilVisible();
            Assert.AreEqual(fourth, OurProduction.OurProduction_Fourth_fieldText);
        }

        [Then(@"I see the fifth OurProduction element is ""(.*)""")]
        public void ThenISeeTheFifthOurProductionElementIs(string fifth)
        {
            OurProduction.OurProduction_Fifth_field.WaitUntilVisible();
            Assert.AreEqual(fifth, OurProduction.OurProduction_Fifth_fieldText);
        }

        [Then(@"I see the sixth OurProduction element is ""(.*)""")]
        public void ThenISeeTheSixthOurProductionElementIs(string sixth)
        {
            OurProduction.OurProduction_Sixth_field.WaitUntilVisible();
            Assert.AreEqual(sixth, OurProduction.OurProduction_Sixth_fieldText);
        }

        [Then(@"I see the seventh OurProduction element is ""(.*)""")]
        public void ThenISeeTheSeventhOurProductionElementIs(string seveth)
        {
            OurProduction.OurProduction_Seventh_field.WaitUntilVisible();
            Assert.AreEqual(seveth, OurProduction.OurProduction_Seventh_fieldText);
        }

        [Then(@"I see the eighth OurProduction element is ""(.*)""")]
        public void ThenISeeTheEighthOurProductionElementIs(string eight)
        {
            OurProduction.OurProduction_Eight_field.WaitUntilVisible();
            Assert.AreEqual(eight, OurProduction.OurProduction_Eight_fieldText);
        }


    }
}
