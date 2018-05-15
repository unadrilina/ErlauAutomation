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
    class RealizedProjectsSteps
    {
        RealizedProjectsPageObject Projects;
        HomePageObject HomePage;
        public Driver _driver;
        public RealizedProjectsSteps(Driver driver)
        {
            _driver = driver;
            Projects = new RealizedProjectsPageObject(driver);
            HomePage = new HomePageObject(driver);
        }

        [When(@"I navigate to Projects page")]
        public void WhenINavigateToProjectsPage()
        {
            HomePage.Navigation_RealizetieProjekti.WaitUntilVisible();
            HomePage.Navigation_RealizetieProjekti.Click();
        }

        [Then(@"I see Projects welcome message ""(.*)""")]
        public void ThenISeeProjectsWelcomeMessage(string projectsTitle)
        {
            Projects.ProjectsTitle.WaitUntilVisible();
            Assert.AreEqual(projectsTitle, Projects.ProjectsTitleText);
        }

        [Then(@"I see Projects page secondary Title ""(.*)""")]
        public void ThenISeeProjectsPageSecondaryTitle(string secondaryTitle)
        {
            Projects.ProjectsSecondaryTitle.WaitUntilVisible();
            Assert.AreEqual(secondaryTitle, Projects.ProjectsSecondaryTitleText);
        }

        [Then(@"I see Project thirth Title ""(.*)""")]
        public void ThenISeeProjectThirthTitle(string thirdthTitle)
        {
            Projects.ProjectsThirdthTitle.WaitUntilVisible();
            Assert.AreEqual(thirdthTitle, Projects.ProjectsThirdthTitleText);
        }

        [Then(@"I see ""(.*)"" Project quality reasosn")]
        public void ThenISeeProjectQualityReasosn(int qualityReasons)
        {
            Assert.AreEqual(qualityReasons, Projects.ProjectsImgList.Count);
        }

        [Then(@"I see the firts Projects quality reason is ""(.*)""")]
        public void ThenISeeFirtsProjectsQualityReasonIs(string firstReason)
        {
            Projects.ProjectsFirstReason.WaitUntilVisible();
            Assert.AreEqual(firstReason, Projects.ProjectsFirstReasonText);
        }

        [Then(@"I see the second Projects quality reason is ""(.*)""")]
        public void ThenISeeTheSecondProjectsQualityReasonIs(string secondReason)
        {
            Projects.ProjectsSecondReason.WaitUntilVisible();
            Assert.AreEqual(secondReason, Projects.ProjectsSecondReasonText);
        }

        [Then(@"I see the third Projects quality reason is ""(.*)""")]
        public void ThenISeeTheThirdProjectsQualityReasonIs(string thirdReason)
        {
            Projects.ProjectsThirdReason.WaitUntilVisible();
            Assert.AreEqual(thirdReason, Projects.ProjectsThirdReasonText);
        }

        [Then(@"I see the fourth Projects quality reason is ""(.*)""")]
        public void ThenISeeTheFourthProjectsQualityReasonIs(string fourthReason)
        {
            Projects.ProjectsFourthReason.WaitUntilVisible();
            Assert.AreEqual(fourthReason, Projects.ProjectsFourthReasonText);
        }

        [Then(@"I see the fifth Projects quality reason is ""(.*)""")]
        public void ThenISeeTheFifthProjectsQualityReasonIs(string fifthReason)
        {
            Projects.ProjectsFivethReason.WaitUntilVisible();
            Assert.AreEqual(fifthReason, Projects.ProjectsFivethReasonText);
        }

        [Then(@"I see the sixth Projects quality reason is ""(.*)""")]
        public void ThenISeeTheSixthProjectsQualityReasonIs(string sixthReason)
        {
            Projects.ProjectsSixthReason.WaitUntilVisible();
            Assert.AreEqual(sixthReason, Projects.ProjectsSixthReasonText);
        }
         
        [Then(@"I see  projects are listed for ""(.*)"" and ""(.*)""")]
        public void ThenISeeProjectsAreListedForand(string firstProjects, string secondProjects)
        {
            Projects.ProjectsFirstPlace.WaitUntilVisible();
            Assert.AreEqual(firstProjects, Projects.ProjectsFirstPlaceText);

            Projects.ProjectsSecondPlace.WaitUntilVisible();
            Assert.AreEqual(secondProjects, Projects.ProjectsSecondPlaceText);
        }
        

    }
}
