using BlueOceanGiftreteWishlist.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueOceanGiftrete.PageObjects
{
    
    class LoginPage
    {
        IWebDriver driver;
        IWebElement clickOnSignIn => driver.FindElement(By.XPath("//div[@class='pa0 flex justify-end dn df-ns ml7-m']//a[contains(@class,'sb-btn2 white f6 f7-m f7-l f7-5-pro f4 fw6 bg-transparent pv2-5 ph3 ttu br1 tracked mr2')][contains(text(),'Sign In')]"));
        IWebElement enterRegisteredEmailAddress => driver.FindElement(By.Id("user_email"));
        IWebElement enterRegisteredPassword => driver.FindElement(By.XPath("//input[@id='user_password']"));
        IWebElement clickSigninButton => driver.FindElement(By.XPath("//input[@id='btn_signin']"));
        IWebElement enterInvalidPassword => driver.FindElement(By.XPath("//input[@id='user_password']"));
        IWebElement userHomePageElement => driver.FindElement(By.XPath("//span[@class='font-size-15 color--light-3']"));
        IWebElement invalidPasswordMessage => driver.FindElement(By.CssSelector("#dng_msg_t"));

        public string GetTextForInvalidPasswordMessage()
        {
            return invalidPasswordMessage.Text;
        }
        public void EnterInvalidPassword()
        {
            enterInvalidPassword.SendKeys("fimisola");
        }

        public bool IsUserHomePageDisplayed()
        {
            return userHomePageElement.Displayed;
        }

        public void ClickSigninButton()
        {
            clickSigninButton.Click();
        }

        public void EnterRegisteredPassword()
        {
            enterRegisteredPassword.SendKeys("yinka1969");
        }


        public void EnterRegisteredEmailAddress()
        {
            enterRegisteredEmailAddress.SendKeys("yinkaland@gmail.com");
        }

        public void ClickOnSignIn()
        {
            clickOnSignIn.Click();
        }

        public void NavigateToGiftrete()
        {
            driver.Navigate().GoToUrl("www.qa.giftrete.com");
        }

        public LoginPage()
        {
            driver = Hook.driver;
        }
    }
}
