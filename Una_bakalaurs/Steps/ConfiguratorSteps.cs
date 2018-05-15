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
    class ConfiguratorSteps
    {
        ConfiguratorPageObject Configurator;
        HomePageObject HomePage;
        public Driver _driver;
        public ConfiguratorSteps(Driver driver)
        {
            _driver = driver;
            Configurator = new ConfiguratorPageObject(driver);
            HomePage = new HomePageObject(driver);
        }

        [When(@"I navigate to Cofigurator page")]
        public void WhenINavigateToCofiguratorPage()
        {
            HomePage.Navigation_Konfigurators.WaitUntilVisible();
            HomePage.Navigation_Konfigurators.Click();
        }

        [Then(@"I see Configurator title ""(.*)""")]
        public void ThenISeeConfiguratorTitle(string configuratorTitle)
        {
            Configurator.ConfiguratorTitleField.WaitUntilVisible();
            Assert.AreEqual(configuratorTitle, Configurator.ConfiguratorTitleFieldText);
        }

        [Then(@"I see ""(.*)"" configuratio options")]
        public void ThenISeeConfiguratioOptions(int configuratorImgCount)
        {
            Assert.AreEqual(configuratorImgCount, Configurator.ConfiguratorImgList.Count);
        }

        [When(@"I select ""(.*)"" option")]
        public void WhenISelectOption(string solsOption)
        {
            if (solsOption.Equals("SOLS"))
            {
                Configurator.ConfiguratorSolsField.WaitUntilVisible();
                Assert.AreEqual(solsOption, Configurator.ConfiguratorSolsFieldText);
                Configurator.ConfiguratorSolsField.Click();
            }
            else if (solsOption.Equals("SOLU SISTĒMA"))
            {
                Configurator.ConfiguratorSoluSistemaField.WaitUntilVisible();
                Assert.AreEqual(solsOption, Configurator.ConfiguratorSoluSistemaFieldText);
                Configurator.ConfiguratorSoluSistemaField.Click();
            }
            else if(solsOption.Equals("SOLU/GALDU K"))
            {
                Configurator.ConfiguratorSoluGalduKombinacijaField.WaitUntilVisible();
                Assert.AreEqual(solsOption, Configurator.ConfiguratorSoluGalduKombinacijaFieldText);
                Configurator.ConfiguratorSoluGalduKombinacijaField.Click();
            }
           
        }

        [Then(@"I see selected configurator Title ""(.*)""")]
        public void ThenISeeSelectedCombinationTitle(string optionTitle)
        {
            if (optionTitle.Equals("KONFIGURATORS - SOLS"))
            {
                Configurator.ConfiguratorSoluTitleField.WaitUntilVisible();
                Assert.AreEqual(optionTitle, Configurator.ConfiguratorSoluTitleFieldText);

            } else if (optionTitle.Equals("Konfigurators solu sistēmas")) {

                Configurator.ConfiguratorSoluSistemaTitleField.WaitUntilVisible();
                Assert.AreEqual(optionTitle, Configurator.ConfiguratorSoluSistemaTitleFieldText);

            }else if (optionTitle.Equals("Konfigurators solu/galdu sistēmas"))
            {
             
            }
        }

        [Then(@"I see Configurator page secondary title ""(.*)""")]
        public void ThenISeeConfiguratorPageSecondaryTitle(string secondaryTitle)
        {
            Configurator.ConfiguratorSecondaryTitleField.WaitUntilVisible();
            Assert.AreEqual(secondaryTitle, Configurator.ConfiguratorSecondaryTitleFieldText);
        }

    }
}
