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
    class GallerySteps
    {
        GalleryPageObject Gallery;
        HomePageObject HomePage;
        public Driver _driver;
        public GallerySteps(Driver driver)
        {
            _driver = driver;
            Gallery = new GalleryPageObject(driver);
            HomePage = new HomePageObject(driver);
        }

        [When(@"I navigate to Gallery page")]
        public void WhenINavigateToGalleryPage()
        {
            HomePage.Navigation_Galerija.WaitUntilVisible();
            HomePage.Navigation_Galerija.Click();
        }

        [Then(@"I see Gallery welcome message ""(.*)""")]
        public void ThenISeeGalleryWelcomeMessage(string galleryTitle)
        {
            Gallery.GalleryTitle.WaitUntilVisible();
            Assert.AreEqual(galleryTitle, Gallery.GalleryTitleText);
        }

        [Then(@"I see ""(.*)"" image in gallery")]
        public void ThenISeeImageInGallery(int imgListSize)
        {
            Assert.AreEqual(imgListSize,Gallery.GalleryImgList.Count);
        }

    }
}
