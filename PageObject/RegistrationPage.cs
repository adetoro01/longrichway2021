using longrichway2021.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace longrichway2021.PageObject
{

    class RegistrationPage
    {
        IWebDriver driver;



        public RegistrationPage()
        {
            driver = WebHook.driver;
        }

        IWebElement register => driver.FindElement(By.XPath("//*[@id='header']/div[2]/div[1]/div/div[1]/div[2]/div[4]/div[2]/a/span"));
        IWebElement firstName => driver.FindElement(By.XPath("//*[@id='firstname']"));
        IWebElement lastName => driver.FindElement(By.XPath("//*[@id='lastname']"));
        IWebElement emailAddress => driver.FindElement(By.XPath("//*[@id='emailaddressreg']"));
        IWebElement phone => driver.FindElement(By.XPath("//*[@id='telephone']"));
        IWebElement passWord => driver.FindElement(By.XPath("//*[@id='passwordreg']"));
        IWebElement confirmPassword => driver.FindElement(By.XPath("//*[@id='cnpassword']"));
        IWebElement address => driver.FindElement(By.XPath("//*[@id='address']"));
        IWebElement townCity => driver.FindElement(By.XPath("//*[@id='city']"));
        IWebElement state => driver.FindElement(By.XPath("//*[@id='state']"));
        IWebElement creatAccount => driver.FindElement(By.XPath("//*[@id='btn_register']"));

        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public void ClickRegister()
        {
            register.Click();
        }
        public void EnterFirstName(string firstNameText)
        {
            firstName.SendKeys(firstNameText);
        }
        public void EnterLastName(string lastNameText)
        {
            lastName.SendKeys(lastNameText);
        }
        public void EnterEmailAddress(string emailText)
        {
            emailAddress.SendKeys(emailText);
        }
        public void EnterPhone(string PhoneText)
        {
            phone.SendKeys(PhoneText);
        }
        public void EnterPassword(string Password)
        {
            passWord.SendKeys(Password);
        }
        public void EnterConfPassword(string ConfPassword)
        {
            confirmPassword.SendKeys(ConfPassword);
        }
        public void EnterAddress(string Address)
        {
            address.SendKeys(Address);
        }
        public void EnterTownCity(string TownCity)
        {
            townCity.SendKeys(TownCity);
        }
        public void EnterState(string State)
        {
            state.SendKeys(State);
        }
        public void ClickCreateAccount(string Createaccount)
        {
            createAccount.Click(Createaccount);
        }
    }
}
