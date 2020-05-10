
using BlueOceanGiftrete.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace BlueOceanGiftreteWishlist.StepDefinitions
{
    [Binding]
    public class RegistrationSteps
    {
      
        RegistrationPage registrationPage;

       
        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }

        [When(@"I enter wrong confirm password")]
        public void WhenIEnterWrongConfirmPassword()
        {
            registrationPage.EnterWrongConfirmPassword();
        }



        [Given(@"I navigate to giftrete")]
        public void GivenINavigateToGiftrete()
        {
            registrationPage.NavigateToGiftreteWebsite();
        }



        [When(@"I click on Create Account")]
        public void WhenIClickOnCreateAccount()
        {
            registrationPage.ClickOnCreateAccount();
        }
        
        [When(@"I enter First Name")]
        public void WhenIEnterFirstName()
        {
            registrationPage.EnterFirstName();
        }
        
        [When(@"I enter Last Name")]
        public void WhenIEnterLastName()
        {
            registrationPage.EnterLastName();
        }

        [When(@"I enter email address")]
        public void WhenIEnterEmailAddress()
        {
            registrationPage.EnterEmailAddress();
        }

        [When(@"I click country code")]
        public void WhenIClickCountryCode()
        {
            registrationPage.ClickOnCountryCode();
        }

        [When(@"I select United Kingdom")]
        public void WhenISelectUnitedKingdom()
        {
            registrationPage.SelectUnitedKingdom();
        }

    

        [When(@"I enter Phone Number")]
        public void WhenIEnterPhoneNumber()
        {
            registrationPage.EnterPhoneNumber();
        }
        
        [When(@"I enter Password")]
        public void WhenIEnterPassword()
        {
            registrationPage.EnterPassword();
        }
        
        [When(@"I enter confirm password")]
        public void WhenIEnterConfirmPassword()
        {
            registrationPage.EnterConfirmPassword();
        }
       

        [When(@"I click on Register button")]
        public void WhenIClickOnRegisterButton()
        {
            registrationPage.ClickOnRegisterButton();
        }

        [Then(@"the message ""(.*)"" should be displayed")]
        public void ThenTheMessageShouldBeDisplayed(string succesfulRegistrationMessage)
        {
            Assert.AreEqual(succesfulRegistrationMessage, registrationPage.GetTextForRegistration());
        }

        [Then(@"error message ""(.*)"" should be displayed")]
        public void ThenErrorMessageShouldBeDisplayed(string errorMessage)
        {
            Assert.AreEqual(errorMessage, registrationPage.GetTextForInvalidConfirmPasswordMessage());
        }

        [Then(@"""(.*)"" should be visible on the page")]
        public void ThenShouldBeVisibleOnThePage()
        {
            Thread.Sleep(5000);
           Assert.True(registrationPage.IsForgotPasswordElementDispalyed());
        }

        [Then(@"I should be registered")]
        public void ThenIShouldBeRegistered()
        {
            Thread.Sleep(5000);
            Assert.True(registrationPage.IsForgotPasswordElementDispalyed());
        }



    }
}
