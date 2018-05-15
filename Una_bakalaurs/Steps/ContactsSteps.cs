using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Una_bakalaurs.Utils;
using Una_bakalaurs.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Una_bakalaurs.Steps
{
    [Binding]
    class ContactsSteps
    {
        ContactsPageObject Contacts;
        HomePageObject HomePage;
        public Driver _driver;
        public ContactsSteps(Driver driver)
        {
            _driver = driver;
            Contacts = new ContactsPageObject(driver);
            HomePage = new HomePageObject(driver);
        }

        [When(@"I navigate to Contacts page")]
        public void GivenINavigateToContactsPage()
        {
            HomePage.Navigation_Kontakti.WaitUntilVisible();
            HomePage.Navigation_Kontakti.Click();
        }

        [Then(@"I see Contacts welcome message ""(.*)""")]
        public void ThenISeeContactsWelcomeMessage(string welcomeMsg)
        {
            Contacts.C_Welcome_Msg.WaitUntilVisible();
            Contacts.C_Welcome_MsgText.Equals(welcomeMsg);
        }

        [When(@"I clik on Contacts form button ""(.*)""")]
        public void WhenIClikOnContactsFormButton(string contact_btn)
        {
            Contacts.Nosutit_Btn.WaitUntilVisible();
            Contacts.Nosutit_Btn.Text.Equals(contact_btn);
            Contacts.Nosutit_Btn.Click();
        }

        [Then(@"I see Address tile ""(.*)""")]
        public void ThenISeeAddressTile(string addressTile)
        {
            Contacts.Adress_Msg.WaitUntilVisible();
            Assert.AreEqual(addressTile, Contacts.Adress_MsgText);
        }
        [Then(@"I see Address street ""(.*)""")]
        public void ThenISeeAddressStreet(string addressStreet)
        {
            Contacts.AdressStreet_Msg.WaitUntilVisible(); ;
            Assert.AreEqual(Contacts.AdressStreet_MsgText, addressStreet);
        }

        [Then(@"I see Address city ""(.*)""")]
        public void ThenISeeAddressCity(string addressCity)
        {
            Contacts.AdressCity_Msg.WaitUntilVisible();
            Assert.AreEqual(Contacts.AdressCity_MsgText, addressCity);
        }

        [Then(@"I see Address country ""(.*)""")]
        public void ThenISeeAddressCountry(string addressCountry)
        {
            Contacts.AdressCountry_Msg.WaitUntilVisible();
            Assert.AreEqual(Contacts.AdressCountry_MsgText, addressCountry);
        }
        [When(@"I add invalid text ""(.*)"" for Email field")]
        public void WhenIAddInvalidTextForEMailField(string invalidText)
        {
            Contacts.AdressEmai_field.WaitUntilVisible();
            Contacts.AdressEmai_field.SendKeys(invalidText);
        }

        [Then(@"I see validation message for Email field ""(.*)""")]
        public void ThenISeeValidationMessageForEmailField(string emailErrorMsg)
        {
            Contacts.AdressEmailError_Msg.WaitUntilVisible();
            Assert.AreEqual(Contacts.AdressEmailError_MsgText, emailErrorMsg);
        }

        [Then(@"I see validation message for Phone field ""(.*)""")]
        public void ThenISeeValidationMessageForPhoneField(string phoneErrorMsg)
        {
            Contacts.AddressPhoneError_Msg.WaitUntilVisible();
            Assert.AreEqual(Contacts.AddressPhoneError_MsgText, phoneErrorMsg);
        }


        [When(@"I add invalid text ""(.*)"" for Phone field")]
        public void WhenIAddInvalidTextForPhoneField(string invalidText)
        {
            Contacts.AdressPhone_Field.WaitUntilVisible();
            Contacts.AdressPhone_Field.SendKeys(invalidText);
        }

        [When(@"I add invalid text ""(.*)"" for Name field")]
        public void WhenIAddInvalidTextForNameField(string invalidText)
        {
            Contacts.C_NameField.WaitUntilVisible();
            Contacts.C_NameField.SendKeys(invalidText);
        }

        [Then(@"I see validation message for Name field ""(.*)""")]
        public void ThenISeeValidationMessageForNameField(string inputtext)
        {
            Contacts.AddressNameError_Msg.WaitUntilVisible();
            Assert.AreEqual(Contacts.AddressNameError_MsgText, inputtext);
        }

        [When(@"I enter ""(.*)"" in email field")]
        public void WhenIEnterInEmailField(string emailtext)
        {
            Contacts.EmailText_Field.WaitUntilVisible();
            Contacts.EmailText_Field.SendKeys(emailtext);
        }
        [Then(@"I see validation message ""(.*)""")]
        public void ThenISeeValidationMessage(string errorMsg)
        {
            Contacts.ValidationError_Msg.WaitUntilVisible();
            Assert.AreEqual(errorMsg, Contacts.ValidationError_MsgText);
        }

        [Then(@"I see Name field decription ""(.*)""")]
        public void ThenISeeNameFieldDecription(string nameDescription)
        {
            Contacts.Name_description_field.WaitUntilVisible();
            Assert.AreEqual(nameDescription, Contacts.Name_description_fieldText);
        }

        [Then(@"I see email field description ""(.*)""")]
        public void ThenISeeEmailFieldDescription(string emailDescription)
        {
            Contacts.Email_description_field.WaitUntilVisible();
            Assert.AreEqual(emailDescription, Contacts.Email_description_fieldText);
        }
        [Then(@"I see phone field description ""(.*)""")]
        public void ThenISeePhoneFieldDescription(string emailDescription)
        {
            Contacts.Phone_description_field.WaitUntilVisible();
            Assert.AreEqual(emailDescription, Contacts.Phone_description_fieldText);
        }

        [Then(@"I see thema field description ""(.*)""")]
        public void ThenISeeThemaFieldDescription(string themaDescription)
        {
            Contacts.Thema_description_field.WaitUntilVisible();
            Assert.AreEqual(themaDescription, Contacts.Thema_description_fieldText);
        }

        [Then(@"I see message field description ""(.*)""")]
        public void ThenISeeMessageFieldDescription(string messageDescription)
        {
            Contacts.Message_description_field.WaitUntilVisible();
            Assert.AreEqual(messageDescription, Contacts.Message_description_fieldText);
        }


    }
}
