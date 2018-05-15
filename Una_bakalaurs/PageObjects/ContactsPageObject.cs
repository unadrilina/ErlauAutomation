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
    class ContactsPageObject
    {
        Driver _driver;
        public ContactsPageObject(Driver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@class='fl-module fl-module-heading-module fl-node-573711214c4b4']//h2")]
        [CacheLookup]
        public IWebElement C_Welcome_Msg { get; set; }
        public string C_Welcome_MsgText => C_Welcome_Msg.Text;

        [FindsBy(How = How.XPath, Using = "//input[@name='your-name']")]
        [CacheLookup]
        public IWebElement C_NameField { get; set; }

        [FindsBy(How = How.ClassName, Using = "wpcf7-submit")]
        [CacheLookup]
        public IWebElement Nosutit_Btn { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".your-name>span")]
        [CacheLookup]
        public IWebElement AddressNameError_Msg { get; set; }
        public String AddressNameError_MsgText => AddressNameError_Msg.Text;

        [FindsBy(How = How.XPath, Using = "//*[contains(@class, 'fl-rich-text')]/h2[1]")]
        [CacheLookup]
        public IWebElement Adress_Msg { get; set; }
        public String Adress_MsgText => Adress_Msg.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-573c96940b71b>div>div>p:nth-child(10)")]
        [CacheLookup]
        public IWebElement AdressStreet_Msg { get; set; }
        public String AdressStreet_MsgText => AdressStreet_Msg.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-573c96940b71b>div>div>p:nth-child(11)")]
        [CacheLookup]
        public IWebElement AdressCity_Msg { get; set; }
        public String AdressCity_MsgText => AdressCity_Msg.Text;

        [FindsBy(How = How.CssSelector, Using = ".fl-node-573c96940b71b>div>div>p:nth-child(12)")]
        [CacheLookup]
        public IWebElement AdressCountry_Msg { get; set; }
        public String AdressCountry_MsgText => AdressCountry_Msg.Text;

        [FindsBy(How = How.XPath, Using = "//input[@type='email']")]
        [CacheLookup]
        public IWebElement AdressEmai_field { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".your-email>span")]
        [CacheLookup]
        public IWebElement AdressEmailError_Msg { get; set; }
        public String AdressEmailError_MsgText => AdressEmailError_Msg.Text;

        [FindsBy(How = How.CssSelector, Using = ".tel-656>span")]
        [CacheLookup]
        public IWebElement AddressPhoneError_Msg { get; set; }
        public String AddressPhoneError_MsgText => AddressPhoneError_Msg.Text;

        [FindsBy(How = How.XPath, Using = "//input[@type='tel']")]
        [CacheLookup]
        public IWebElement AdressPhone_Field { get; set; }

        [FindsBy(How = How.ClassName, Using = "wpcf7-validation-errors")]
        [CacheLookup]
        public IWebElement ValidationError_Msg { get; set; }
        public String ValidationError_MsgText => ValidationError_Msg.Text;

        [FindsBy(How = How.Name, Using = "your-message")]
        [CacheLookup]
        public IWebElement EmailText_Field { get; set; }
        public String EmailText_FieldText => EmailText_Field.Text;

        [FindsBy(How = How.XPath, Using = "//form[contains(text(),'')]/p[1]")]
        [CacheLookup]
        public IWebElement Name_description_field { get; set; }
        public String Name_description_fieldText => Name_description_field.Text;

        [FindsBy(How = How.XPath, Using = "//form[contains(text(),'')]/p[2]")]
        [CacheLookup]
        public IWebElement Email_description_field { get; set; }
        public String Email_description_fieldText => Email_description_field.Text;

        [FindsBy(How = How.XPath, Using = "//form[contains(text(),'')]/p[3]")]
        [CacheLookup]
        public IWebElement Phone_description_field { get; set; }
        public String Phone_description_fieldText => Phone_description_field.Text;

        [FindsBy(How = How.XPath, Using = "//form[contains(text(),'')]/p[4]")]
        [CacheLookup]
        public IWebElement Thema_description_field { get; set; }
        public String Thema_description_fieldText => Thema_description_field.Text;

        [FindsBy(How = How.XPath, Using = "//form[contains(text(),'')]/p[5]")]
        [CacheLookup]
        public IWebElement Message_description_field { get; set; }
        public String Message_description_fieldText => Message_description_field.Text;
    }
}
