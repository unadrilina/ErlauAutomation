using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Una_bakalaurs.PageObjects;
using Una_bakalaurs.Utils;




namespace Una_bakalaurs.Steps
{
    [Binding]
   public class HomePageSteps
    {
       
        HomePageObject HomePage;
        RealizedProjectsPageObject RealizedProjects;
        ConfiguratorPageObject Configurator;
        OurProductionPageObject OurProduction;
        public Driver _driver;
        public HomePageSteps (Driver driver)
        {
            HomePage = new HomePageObject(driver);
            OurProduction = new OurProductionPageObject(driver);
            Configurator = new ConfiguratorPageObject(driver);
            RealizedProjects = new RealizedProjectsPageObject(driver);
        }
        
       
        [Given(@"I am on home page")]
        public void GivenIAmOnHomePage()
        {
            HomePage.LogoImg.WaitUntilVisible();
            HomePage.LogoImg.Displayed.Equals(true);
        }

        [Then(@"I see Home page open")]
        public void ThenISeeHomePageOpen()
        {
            string HomePagetiletext = "OFICIĀLAIS PĀRSTĀVIS BALTIJAS VALSTĪS, KRIEVIJĀ, UKRAINĀ UN BALTKRIEVIJĀ";
            HomePage.HomePageTitleField.WaitUntilVisible();
            HomePage.HomePageTitleFieldText.Equals(HomePagetiletext);            
        }

        [When(@"I see HomePage second title ""(.*)""")]
        public void ThenISeeHomePageSecondTitle(string secondTitle)
        {
            HomePage.HomePageReasosn_field.WaitUntilVisible();
            Assert.AreEqual(HomePage.HomePageReasosn_fieldText, secondTitle);
        }

        [Then(@"I see ""(.*)"" reasons to use Erlau production")]
        public void ThenISeeReasonsToUseErlauProduction(int reasonsSum)
        {         
            Assert.AreEqual(reasonsSum, HomePage.HomePageReasosnImg_List.Count);
        }

        [Then(@"I see the first reason is ""(.*)""")]
        public void ThenISeetheFirstReasonIs(string firstReasons)
        {
            HomePage.HomePageFirstReasosn_field.WaitUntilVisible();
            Assert.AreEqual(firstReasons, HomePage.HomePageFirstReasosn_fieldText.Replace("\n·       ", "").Replace('\r',','));          
        }

        [Then(@"I see the second reason is ""(.*)""")]
        public void ThenISeetheSecondReasonIs(string secondReason)
        {
            HomePage.HomePageSecondReasosn_field.WaitUntilVisible();
            Assert.AreEqual(secondReason, HomePage.HomePageSecondReasosn_fieldText);
        }

        [Then(@"I see the third reason is ""(.*)""")]
        public void ThenISeeTheThirdReasonIs(string thirdReason)
        {
            HomePage.HomePageThirdReasosn_field.WaitUntilVisible();
            Assert.AreEqual(thirdReason, HomePage.HomePageThirdReasosn_fieldText);
        }

        [Then(@"I see the fourth reason is ""(.*)""")]
        public void ThenISeeTheFourthReasonIs(string fourthReason)
        {
            HomePage.HomePageFourthReasosn_field.WaitUntilVisible();
            Assert.AreEqual(fourthReason, HomePage.HomePageFourthReasosn_fieldText);
        }

        [Then(@"I see the fifth reason is ""(.*)""")]
        public void ThenISeeTheFifthReasonIs(string fifthReason)
        {
            HomePage.HomePageFifthReasosn_field.WaitUntilVisible();
            Assert.AreEqual(fifthReason, HomePage.HomePageFifthReasosn_fieldText);
        }

        [Then(@"I see the sixth reason is ""(.*)""")]
        public void ThenISeeTheSixthReasonIs(string sixthReason)
        {
            HomePage.HomePageSixthReasosn_field.WaitUntilVisible();
            Assert.AreEqual(sixthReason, HomePage.HomePageSixthReasosn_fieldText);
        }

        [Then(@"I see the seventh reason is ""(.*)""")]
        public void ThenISeeTheSeventhReasonIs(string seventhReason)
        {
            HomePage.HomePageSeventhReasosn_field.WaitUntilVisible();
            Assert.AreEqual(seventhReason, HomePage.HomePageSeventhReasosn_fieldText);
        }

        [Then(@"I see the eighth reason is ""(.*)""")]
        public void ThenISeeTheEighthReasonIs(string eightReason)
        {
            HomePage.HomePageEighthReasosn_field.WaitUntilVisible();
            Assert.AreEqual(eightReason, HomePage.HomePageEighthReasosn_fieldText);
        }

        [Then(@"I see the ninth reason is ""(.*)""")]
        public void ThenISeeTheNinthReasonIs(string ninthReason)
        {
            HomePage.HomePageNinthReasosn_field.WaitUntilVisible();
            Assert.AreEqual(ninthReason, HomePage.HomePageNinthReasosn_fieldText);
        }

        [Then(@"I see the tenth reason is ""(.*)""")]
        public void ThenISeeTheTenthReasonIs(string tenthReason)
        {
            HomePage.HomePageTenthReasosn_field.WaitUntilVisible();
            Assert.AreEqual(tenthReason, HomePage.HomePageTenthReasosn_fieldText);
        }

        [Then(@"I see Home Page footer title ""(.*)""")]
        public void ThenISeeHomePageFooterTitle(string footerTitle)
        {
            HomePage.HomePageFooterTitle_field.WaitUntilVisible();
            Assert.AreEqual(footerTitle, HomePage.HomePageFooterTitle_fieldText);
        }

        [When(@"I click on footer href ""(.*)""")]
        public void WhenIClickOnFooterHref(string footerHref)
        {
            HomePage.HomePageFooterHref_field.WaitUntilVisible();
            Assert.AreEqual(footerHref, HomePage.HomePageFooterHref_fieldText);
            HomePage.HomePageFooterHref_field.Click();
        }

        [When(@"I click on Home Page footer href ""(.*)""")]
        public void WhenIClickOnHomePageFooterHref(string hreflink)
        {
            if (hreflink.Equals("MŪSU PRODUKCIJA"))
            {
                HomePage.FooterHref_MusuProdukcijas_field.WaitUntilVisible();
                Assert.AreEqual(hreflink, HomePage.FooterHref_MusuProdukcijas_fieldText);
                HomePage.FooterHref_MusuProdukcijas_field.Click();

            }
            else if (hreflink.Equals("Soliņi"))
            {
                HomePage.FooterHref_Solini_field.WaitUntilVisible();
                Assert.AreEqual(hreflink, HomePage.FooterHref_Solini_fieldText);
                HomePage.FooterHref_Solini_field.Click();
            }
            else if (hreflink.Equals("Solu sistēmas"))
            {
                HomePage.FooterHref_SolinuSistemas_field.WaitUntilVisible();
                Assert.AreEqual(hreflink, HomePage.FooterHref_SolinuSistemas_fieldText);
                HomePage.FooterHref_SolinuSistemas_field.Click();
            }
            else if (hreflink.Equals("Solu/galdu kombinācijas"))
            {
                HomePage.FooterHref_SolinuGalduKombinacijas_field.WaitUntilVisible();
                Assert.AreEqual(hreflink, HomePage.FooterHref_SolinuGalduKombinacijas_fieldText);
                HomePage.FooterHref_SolinuGalduKombinacijas_field.Click();
            }
            else if (hreflink.Equals("Galdi"))
            {
                HomePage.FooterHref_Galdi_field.WaitUntilVisible();
                Assert.AreEqual(hreflink, HomePage.FooterHref_Galdi_fieldText);
                HomePage.FooterHref_Galdi_field.Click();
            }
            else if (hreflink.Equals("Krēsli/sauļošanās krēsli"))
            {
                HomePage.FooterHref_KresliSaulosanasKresli_field.WaitUntilVisible();
                Assert.AreEqual(hreflink, HomePage.FooterHref_KresliSaulosanasKresli_fieldText);
                HomePage.FooterHref_KresliSaulosanasKresli_field.Click();
            }
            else if (hreflink.Equals("Atkritumu konteineri/konteineri augiem"))
            {
                HomePage.FooterHref_AtkritumuKonteineri_field.WaitUntilVisible();
                Assert.AreEqual(hreflink, HomePage.FooterHref_AtkritumuKonteineri_fieldText);
                HomePage.FooterHref_AtkritumuKonteineri_field.Click();
            }
            else if (hreflink.Equals("Velosipēdu novietnes/norobežojumi"))
            {
                HomePage.FooterHref_VelosipeduNovietnes_field.WaitUntilVisible();
                Assert.AreEqual(hreflink, HomePage.FooterHref_VelosipeduNovietnes_fieldText);
                HomePage.FooterHref_VelosipeduNovietnes_field.Click();
            }
            else if (hreflink.Equals("Aprīkojums fitnesam"))
            {
                HomePage.FooterHref_AprikojumsFitnesam_field.WaitUntilVisible();
                Assert.AreEqual(hreflink, HomePage.FooterHref_AprikojumsFitnesam_fieldText);
                HomePage.FooterHref_AprikojumsFitnesam_field.Click();
            }
            else if (hreflink.Equals("KONFIGURATORS"))
            {
                HomePage.FooterHref_Konfigurators_field.WaitUntilVisible();
                Assert.AreEqual(hreflink, HomePage.FooterHref_Konfigurators_fieldText);
                HomePage.FooterHref_Konfigurators_field.Click();
            }
            else if (hreflink.Equals("Konfigurators – solu sistēma"))
            {
                HomePage.FooterHref_KonfiguratorsSoluSistema_field.WaitUntilVisible();
                Assert.AreEqual(hreflink, HomePage.FooterHref_KonfiguratorsSoluSistema_fieldText);
                HomePage.FooterHref_KonfiguratorsSoluSistema_field.Click();
            }
            else if (hreflink.Equals("Konfigurators – galdu sistēma"))
            {
                HomePage.FooterHref_KonfiguratorsGalduSistema_field.WaitUntilVisible();
                Assert.AreEqual(hreflink, HomePage.FooterHref_KonfiguratorsGalduSistema_fieldText);
                HomePage.FooterHref_KonfiguratorsGalduSistema_field.Click();
            }
            else if (hreflink.Equals("Konfigurators – sols"))
            {
                HomePage.FooterHref_KonfiguratorsSols_field.WaitUntilVisible();
                Assert.AreEqual(hreflink, HomePage.FooterHref_KonfiguratorsSols_fieldText);
                HomePage.FooterHref_KonfiguratorsSols_field.Click();
            }
            else if (hreflink.Equals("REALIZĒTIE PROJEKTI"))
            {
                HomePage.FooterHref_RealizetieProjekti_field.WaitUntilVisible();
                Assert.AreEqual(hreflink, HomePage.FooterHref_RealizetieProjekti_fieldText);
                HomePage.FooterHref_RealizetieProjekti_field.Click();
            }
            else if (hreflink.Equals("Terms of use"))
            {
                HomePage.FooterHref_TermsOfUse_field.WaitUntilVisible();
                Assert.AreEqual(hreflink, HomePage.FooterHref_TermsOfUse_fieldText);
                HomePage.FooterHref_TermsOfUse_field.Click();
            }
            else {
                Console.WriteLine("Cant finde href " +hreflink);
            }
        }

        [Then(@"I see ""(.*)"" page with tile ""(.*)""")]
        public void ThenISeePageWithTile(string hreflink, string title)
        {
            if (hreflink.Equals("MŪSU PRODUKCIJA"))
            {
                OurProduction.OurProductionTitle_field.WaitUntilVisible();
                Assert.AreEqual(title, OurProduction.OurProductionTitle_fieldText);

            }
            else if (hreflink.Equals("Soliņi"))
            {
                OurProduction.SoliTitle_field.WaitUntilVisible();
                Assert.AreEqual(title, OurProduction.SoliTitle_fieldText);
            }
            else if (hreflink.Equals("Solu sistēmas"))
            {
                OurProduction.SoluSistemaTitle_field.WaitUntilVisible();
                Assert.AreEqual(title, OurProduction.SoluSistemaTitle_fieldText);
            }
            else if (hreflink.Equals("Solu/galdu kombinācijas"))
            {
                OurProduction.SoluGalduKombinacijaTitle_field.WaitUntilVisible();
                Assert.AreEqual(title, OurProduction.SoluGalduKombinacijaTitle_fieldText);
            }
            else if (hreflink.Equals("Galdi"))
            {
                OurProduction.GaldiTitle_field.WaitUntilVisible();
                Assert.AreEqual(title, OurProduction.GaldiTitle_fieldText);
            }
            else if (hreflink.Equals("Krēsli/sauļošanās krēsli"))
            {
                OurProduction.SaulosanasKresli_field.WaitUntilVisible();
                Assert.AreEqual(title, OurProduction.SaulosanasKresli_fieldText);
            }
            else if (hreflink.Equals("Atkritumu konteineri/konteineri augiem"))
            {
                OurProduction.AtkritumuKonteineri_field.WaitUntilVisible();
                Assert.AreEqual(title, OurProduction.AtkritumuKonteineri_fieldText);
            }
            else if (hreflink.Equals("Velosipēdu novietnes/norobežojumi"))
            {
                OurProduction.VelosipeduNovietne_field.WaitUntilVisible();
                Assert.AreEqual(title, OurProduction.VelosipeduNovietne_fieldText);
            }
            else if (hreflink.Equals("Aprīkojums fitnesam"))
            {
                OurProduction.AprikojumsFitenesam_field.WaitUntilVisible();
                Assert.AreEqual(title, OurProduction.AprikojumsFitenesam_fieldText);
            }
            else if (hreflink.Equals("KONFIGURATORS"))
            {
                Configurator.ConfiguratorTitleField.WaitUntilVisible();
                Assert.AreEqual(title, Configurator.ConfiguratorTitleFieldText);
            }
            else if (hreflink.Equals("Konfigurators – solu sistēma"))
            {
                OurProduction.KonfiguaratorsSoluSist_field.WaitUntilVisible();
                Assert.AreEqual(title, OurProduction.KonfiguaratorsSoluSist_fieldText);
            }
            else if (hreflink.Equals("Konfigurators – galdu sistēma"))
            {
                OurProduction.KonfiguaratorsGalduSistImg_field.WaitUntilVisible();
                Assert.IsTrue(OurProduction.KonfiguaratorsGalduSistImg_field.Displayed);
            }
            else if (hreflink.Equals("Konfigurators – sols"))
            {
                OurProduction.KonfiguaratorsSolsImg_field.WaitUntilVisible();
                Assert.IsTrue(OurProduction.KonfiguaratorsSolsImg_field.Displayed);
            }
            else if (hreflink.Equals("REALIZĒTIE PROJEKTI"))
            {
                RealizedProjects.ProjectsTitle.WaitUntilVisible();
                Assert.AreEqual(title, RealizedProjects.ProjectsTitleText);
            }
            else if (hreflink.Equals("Terms of use"))
            {
                OurProduction.TermsOfUseTitle_field.WaitUntilVisible();
                Assert.AreEqual(title, OurProduction.TermsOfUseTitle_fieldText);
            }
            else
            {
                Console.WriteLine("Cant finde href " + hreflink);
            }
        }
        [Then(@"I see navigation elements are ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void ThenISeeNavigationElementsAre(string produkcija, string konfigurators, string projekti, string galerija, string kontakti)
        {
            HomePage.Navigation_MusuProdukcija.WaitUntilVisible();
            Assert.AreEqual(produkcija, HomePage.Navigation_MusuProdukcijaText);

            HomePage.Navigation_Konfigurators.WaitUntilVisible();
            Assert.AreEqual(konfigurators, HomePage.Navigation_KonfiguratorsText);

            HomePage.Navigation_RealizetieProjekti.WaitUntilVisible();
            Assert.AreEqual(projekti, HomePage.Navigation_RealizetieProjektiText);

            HomePage.Navigation_Galerija.WaitUntilVisible();
            Assert.AreEqual(galerija, HomePage.Navigation_GalerijaText);

            HomePage.Navigation_Kontakti.WaitUntilVisible();
            Assert.AreEqual(kontakti, HomePage.Navigation_KontaktiText);

        }






    }
}
