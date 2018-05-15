using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using Una_bakalaurs.Utils;

namespace Una_bakalaurs.PageObjects
{
    class HomePageObject
    {
        Driver _driver;
        public HomePageObject(Driver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver.driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "site-branding")]
        [CacheLookup]
        public IWebElement LogoImg { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#post-33>div>div>div.fl-row.fl-row-full-width.fl-row-bg-color.fl-node-56fa982281b32>div>div>div>div.fl-col.fl-col-small.fl-node-574d73d2d9664>div>div>div>h2")]
        [CacheLookup]
        public IWebElement HomePageTitleField { get; set; }
        public string HomePageTitleFieldText => HomePageTitleField.Text;

        [FindsBy(How = How.Id, Using = "site-navigation")]
        [CacheLookup]
        public IWebElement HomePageNavigationt { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='site-navigation'] //li/a[text()='MŪSU PRODUKCIJA']")]
        [CacheLookup]
        public IWebElement Navigation_MusuProdukcija { get; set; }
        public string Navigation_MusuProdukcijaText => Navigation_MusuProdukcija.Text;

        [FindsBy(How = How.XPath, Using = "//*[@id='site-navigation'] //li/a[text()='KONFIGURATORS']")]
        [CacheLookup]
        public IWebElement Navigation_Konfigurators { get; set; }
        public string Navigation_KonfiguratorsText => Navigation_Konfigurators.Text;

        [FindsBy(How = How.XPath, Using = "//*[@id='site-navigation'] //li/a[text()='REALIZĒTIE PROJEKTI']")]
        [CacheLookup]
        public IWebElement Navigation_RealizetieProjekti { get; set; }
        public string Navigation_RealizetieProjektiText => Navigation_RealizetieProjekti.Text;

        [FindsBy(How = How.XPath, Using = "//*[@id='site-navigation'] //li/a[text()='GALERIJA']")]
        [CacheLookup]
        public IWebElement Navigation_Galerija { get; set; }
        public string Navigation_GalerijaText => Navigation_Galerija.Text;

        [FindsBy(How = How.XPath, Using = "//*[@id='site-navigation']//li/a[text()='KONTAKTI']")]
        [CacheLookup]
        public IWebElement Navigation_Kontakti { get; set; }
        public string Navigation_KontaktiText => Navigation_Kontakti.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-57612898f2daa>div>div>p>span")]
        [CacheLookup]
        public IWebElement HomePageReasosn_field { get; set; }
        public string HomePageReasosn_fieldText => HomePageReasosn_field.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-photo.fl-photo-align-center")]
        public IList<IWebElement> HomePageReasosnImg_List { get; set; } // List of result Images

        [FindsBy(How = How.CssSelector, Using = ".fl-node-5761285c4a147>div>div>p")]
        [CacheLookup]
        public IWebElement HomePageFirstReasosn_field { get; set; }
        public string HomePageFirstReasosn_fieldText => HomePageFirstReasosn_field.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-57612657e95e3>div>div>p:nth-child(1)")]
        [CacheLookup]
        public IWebElement HomePageSecondReasosn_field { get; set; }
        public string HomePageSecondReasosn_fieldText => HomePageSecondReasosn_field.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-578372656f744>div>div>p:nth-child(1)")]
        [CacheLookup]
        public IWebElement HomePageThirdReasosn_field { get; set; }
        public string HomePageThirdReasosn_fieldText => HomePageThirdReasosn_field.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-578372f578297>div>div>p:nth-child(1)")]
        [CacheLookup]
        public IWebElement HomePageFourthReasosn_field { get; set; }
        public string HomePageFourthReasosn_fieldText => HomePageFourthReasosn_field.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-578372ffb003f>div>div>p:nth-child(1)")]
        [CacheLookup]
        public IWebElement HomePageFifthReasosn_field { get; set; }
        public string HomePageFifthReasosn_fieldText => HomePageFifthReasosn_field.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-578372ffb0061>div>div>p:nth-child(1)")]
        [CacheLookup]
        public IWebElement HomePageSixthReasosn_field { get; set; }
        public string HomePageSixthReasosn_fieldText => HomePageSixthReasosn_field.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-5783733fc2bc1>div>div>p:nth-child(1)")]
        [CacheLookup]
        public IWebElement HomePageSeventhReasosn_field { get; set; }
        public string HomePageSeventhReasosn_fieldText => HomePageSeventhReasosn_field.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-5783733fc2be1>div>div>p:nth-child(1)")]
        [CacheLookup]
        public IWebElement HomePageEighthReasosn_field { get; set; }
        public string HomePageEighthReasosn_fieldText => HomePageEighthReasosn_field.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-57837378b7130>div>div>p:nth-child(1)")]
        [CacheLookup]
        public IWebElement HomePageNinthReasosn_field { get; set; }
        public string HomePageNinthReasosn_fieldText => HomePageNinthReasosn_field.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-57837378b7152>div>div>p:nth-child(1)")]
        [CacheLookup]
        public IWebElement HomePageTenthReasosn_field { get; set; }
        public string HomePageTenthReasosn_fieldText => HomePageTenthReasosn_field.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-574da141b7113>div>h2")]
        [CacheLookup]
        public IWebElement HomePageFooterTitle_field { get; set; }
        public string HomePageFooterTitle_fieldText => HomePageFooterTitle_field.Text;


        [FindsBy(How = How.CssSelector, Using = ".fl-node-574da141bae1c>div>div>p>span>a")]
        [CacheLookup]
        public IWebElement HomePageFooterHref_field { get; set; }
        public string HomePageFooterHref_fieldText => HomePageFooterHref_field.Text;

        [FindsBy(How = How.CssSelector, Using = "#menu-item-314>a")]
        [CacheLookup]
        public IWebElement FooterHref_MusuProdukcijas_field { get; set; }
        public string FooterHref_MusuProdukcijas_fieldText => FooterHref_MusuProdukcijas_field.Text;

        [FindsBy(How = How.CssSelector, Using = "#menu-item-307>a")]
        [CacheLookup]
        public IWebElement FooterHref_Solini_field { get; set; }
        public string FooterHref_Solini_fieldText => FooterHref_Solini_field.Text;

        [FindsBy(How = How.CssSelector, Using = "#menu-item-338>a")]
        [CacheLookup]
        public IWebElement FooterHref_SolinuSistemas_field { get; set; }
        public string FooterHref_SolinuSistemas_fieldText => FooterHref_SolinuSistemas_field.Text;

        [FindsBy(How = How.CssSelector, Using = "#menu-item-337>a")]
        [CacheLookup]
        public IWebElement FooterHref_SolinuGalduKombinacijas_field { get; set; }
        public string FooterHref_SolinuGalduKombinacijas_fieldText => FooterHref_SolinuGalduKombinacijas_field.Text;

        [FindsBy(How = How.CssSelector, Using = "#menu-item-336>a")]
        [CacheLookup]
        public IWebElement FooterHref_Galdi_field { get; set; }
        public string FooterHref_Galdi_fieldText => FooterHref_Galdi_field.Text;

        [FindsBy(How = How.CssSelector, Using = "#menu-item-335>a")]
        [CacheLookup]
        public IWebElement FooterHref_KresliSaulosanasKresli_field { get; set; }
        public string FooterHref_KresliSaulosanasKresli_fieldText => FooterHref_KresliSaulosanasKresli_field.Text;

        [FindsBy(How = How.CssSelector, Using = "#menu-item-334>a")]
        [CacheLookup]
        public IWebElement FooterHref_AtkritumuKonteineri_field { get; set; }
        public string FooterHref_AtkritumuKonteineri_fieldText => FooterHref_AtkritumuKonteineri_field.Text;

        [FindsBy(How = How.CssSelector, Using = "#menu-item-332>a")]
        [CacheLookup]
        public IWebElement FooterHref_VelosipeduNovietnes_field { get; set; }
        public string FooterHref_VelosipeduNovietnes_fieldText => FooterHref_VelosipeduNovietnes_field.Text;

        [FindsBy(How = How.CssSelector, Using = "#menu-item-333>a")]
        [CacheLookup]
        public IWebElement FooterHref_AprikojumsFitnesam_field { get; set; }
        public string FooterHref_AprikojumsFitnesam_fieldText => FooterHref_AprikojumsFitnesam_field.Text;

        [FindsBy(How = How.CssSelector, Using = "#menu-item-315>a")]
        [CacheLookup]
        public IWebElement FooterHref_Konfigurators_field { get; set; }
        public string FooterHref_Konfigurators_fieldText => FooterHref_Konfigurators_field.Text;

        [FindsBy(How = How.CssSelector, Using = "#menu-item-308>a")]
        [CacheLookup]
        public IWebElement FooterHref_KonfiguratorsSoluSistema_field { get; set; }
        public string FooterHref_KonfiguratorsSoluSistema_fieldText => FooterHref_KonfiguratorsSoluSistema_field.Text;

        [FindsBy(How = How.CssSelector, Using = "#menu-item-309>a")]
        [CacheLookup]
        public IWebElement FooterHref_KonfiguratorsGalduSistema_field { get; set; }
        public string FooterHref_KonfiguratorsGalduSistema_fieldText => FooterHref_KonfiguratorsGalduSistema_field.Text;

        [FindsBy(How = How.CssSelector, Using = "#menu-item-310>a")]
        [CacheLookup]
        public IWebElement FooterHref_KonfiguratorsSols_field { get; set; }
        public string FooterHref_KonfiguratorsSols_fieldText => FooterHref_KonfiguratorsSols_field.Text;

        [FindsBy(How = How.CssSelector, Using = "#menu-item-311>a")]
        [CacheLookup]
        public IWebElement FooterHref_RealizetieProjekti_field { get; set; }
        public string FooterHref_RealizetieProjekti_fieldText => FooterHref_RealizetieProjekti_field.Text;

        [FindsBy(How = How.CssSelector, Using = "#menu-item-312>a")]
        [CacheLookup]
        public IWebElement FooterHref_TermsOfUse_field { get; set; }
        public string FooterHref_TermsOfUse_fieldText => FooterHref_TermsOfUse_field.Text;


    }

}
