using BlueOceanGiftrete.PageObjects;
using NUnit.Framework;
using System.Threading;
using TechTalk.SpecFlow;

namespace BlueOceanGiftreteWishlist.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {

        LoginPage loginPage;

        public LoginSteps()
        {
            loginPage = new LoginPage();
        }

        public void ThenErrorMessageShouldBeDisplayed(string errorMessage)
        {
            Assert.AreEqual(errorMessage, loginPage.GetTextForInvalidPasswordMessage());
        }


        [Then(@"I should not be able to signed in")]
        public void ThenIShouldNotBeAbleToSignedIn()
        {
            
        }


        [When(@"I enter my invalid password")]
        public void WhenIEnterMyInvalidPassword()
        {
            loginPage.EnterInvalidPassword();
        }

        [Given(@"I click on sign in")]
        public void GivenIClickOnSignIn()
        {
            loginPage.ClickOnSignIn();
        }
        
        [When(@"I enter my registered email address")]
        public void WhenIEnterMyRegisteredEmailAddress()
        {
            loginPage.EnterRegisteredEmailAddress();
        }
        
        [When(@"I enter my registered password")]
        public void WhenIEnterMyRegisteredPassword()
        {
            loginPage.EnterRegisteredPassword();
        }
        
        [When(@"I click on sign in button")]
        public void WhenIClickOnSignInButton()
        {
            Thread.Sleep(5000);
            loginPage.ClickSigninButton();
        }
        
        [Then(@"I should be signed in")]
        public void ThenIShouldBeSignedIn()
        {
            Assert.True(loginPage.IsUserHomePageDisplayed());
        }

        [Then(@"my user homepage should be displayed")]
        public void ThenMyUserHomepageShouldBeDisplayed()
        {
            Thread.Sleep(5000);
            Assert.True(loginPage.IsUserHomePageDisplayed());
        }

    }
}
