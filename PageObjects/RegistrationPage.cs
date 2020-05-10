using BlueOceanGiftreteWishlist.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BlueOceanGiftrete.PageObjects
{
    class RegistrationPage
    {
        IWebDriver driver;
        IWebElement enterLastName => driver.FindElement(By.XPath("//*[@id='last_name']"));
        IWebElement enterFirstName => driver.FindElement(By.XPath("//*[@id='first_name']"));
        IWebElement clickOnCreateAccount => driver.FindElement(By.XPath("/html/body/section[1]/nav/div/div[1]/a[2]"));
        IWebElement enterEmailAddress => driver.FindElement(By.XPath("//*[@id='email']"));
        IWebElement clickOnCountryCode => driver.FindElement(By.CssSelector("#nav-register > form > div:nth-child(4) > div > div > div > div.iti-flag.gb"));
        IWebElement selectUnitedKingdom => driver.FindElement(By.CssSelector("#iti-item-gb > span.country-name"));
        IWebElement enterPhoneNumber => driver.FindElement(By.XPath("//*[@id='mobile']"));
        IWebElement enterPassword => driver.FindElement(By.XPath("//*[@id='password']"));
        IWebElement enterConfirmPassword => driver.FindElement(By.XPath("//*[@id='confirm_password']"));
        IWebElement clickOnRegisterButton => driver.FindElement(By.XPath("//*[@id='btn_register']"));
        IWebElement enterWrongConfirmPassword => driver.FindElement(By.XPath("//*[@id='confirm_password']"));
        IWebElement invalidConfirmPasswordMessage => driver.FindElement(By.CssSelector("#dng_msg > p"));
        IWebElement successfulRegistrationMessage => driver.FindElement(By.CssSelector("#suc_id"));

        IWebElement forgotPasswordElement => driver.FindElement(By.CssSelector("#nav-signin > form > div.form__group.mb--30 > div > a"));

        public string GetTextForRegistration()
        {
            return successfulRegistrationMessage.Text;
        }

        public bool IsForgotPasswordElementDispalyed()
        {
            return forgotPasswordElement.Displayed;
        }





        public string GetTextForInvalidConfirmPasswordMessage()
        {
            return invalidConfirmPasswordMessage.Text;
        }

        public void EnterWrongConfirmPassword()
        {
            enterConfirmPassword.SendKeys("yinka");
        }
        
        public void ClickOnRegisterButton()
        {
            clickOnRegisterButton.Click();
        }

        public void EnterConfirmPassword()
        {
            enterConfirmPassword.SendKeys("fimisola07");
        }

        public void EnterPassword()
        {
            enterPassword.SendKeys("fimisola07");
        }
        public void EnterPhoneNumber()
        {
            enterPhoneNumber.SendKeys("07923456890");
        }
        public void SelectUnitedKingdom()
        {
            selectUnitedKingdom.Click();
        }
        public void ClickOnCountryCode()
        {
            clickOnCountryCode.Click();
        }
        public void EnterEmailAddress()
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            enterEmailAddress.SendKeys("fimron2sowunmi" + randomInt + "@gmail.com");
        }
        public void EnterLastName()
        {
            enterLastName.SendKeys("Sowunmi");
        }
        public void EnterFirstName()
        {
            enterFirstName.SendKeys("Ronel");
        }
        public void ClickOnCreateAccount()
        {
            clickOnCreateAccount.Click();
        }


        public void NavigateToGiftreteWebsite()
        {
            driver.Navigate().GoToUrl("http://www.qa.giftrete.com/");
        }
        public RegistrationPage()
        {
            driver = Hook.driver;
        }

    }
}
