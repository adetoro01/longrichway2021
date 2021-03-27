using longrichway2021.PageObject;
using System;
using TechTalk.SpecFlow;


namespace longrichway2021.Steps
{
    [Binding]
    public class RegistrationSteps
    {

        RegistrationPage registrationPage;
        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }
        [Given(@"a user navigate to ""(.*)""")]
        public void GivenAUserNavigateTo(string url)
        {
            registrationPage.Navigate(url);
        }

        [When(@"a user Clicks on register")]
        public void WhenAUserClicksOnRegister()
        {
            registrationPage.ClickRegister();
        }

        [When(@"user enters Firstname ""(.*)""")]
        public void WhenUserEntersFirstname(string firstNameText)
        {
            registrationPage.EnterFirstName(firstNameText);
        }

        [When(@"the user enters Last Name ""(.*)""")]
        public void WhenTheUserEntersLastName(string lastNameText)
        {
            registrationPage.EnterLastName(lastNameText);
        }

        [When(@"the user enters Email Address ""(.*)""")]
        public void WhenTheUserEntersEmailAddress(string emailText)
        {
            registrationPage.EnterEmailAddress(emailText);
        }

        [When(@"user enters Phone ""(.*)""")]
        public void WhenUserEntersPhone(string PhoneText)
        {
            registrationPage.EnterPhone(PhoneText);
        }

        [When(@"user enters Password ""(.*)""")]
        public void WhenUserEntersPassword(string Password)
        {
            registrationPage.EnterPassword(Password);
        }

        [When(@"user enters Confirm Password ""(.*)""")]
        public void WhenUserEntersConfirmPassword(string ConfPassword)
        {
            registrationPage.EnterConfPassword(ConfPassword);
        }

        [When(@"user enters Address ""(.*)""")]
        public void WhenUserEntersAddress(string Address)
        {
            registrationPage.EnterAddress(Address);
        }

        [When(@"user enters TownCity ""(.*)""")]
        public void WhenUserEntersTownCity(string TownCity)
        {
            registrationPage.EnterTownCity(TownCity);
        }

        [When(@"user enters State ""(.*)""")]
        public void WhenUserEntersState(string State)
        {
            registrationPage.EnterState(State);
        }

        [When(@"the user Clicks on Create Account")]
        public void WhenTheUserClicksOnCreateAccount(string CreateAccount)
        {
            registrationPage.ClickCreateAccount(CreateAccount);
        }

        [Then(@"the user is logged into New Account")]
        public void ThenTheUserIsLoggedIntoNewAccount()
        {

        }
    }
}
