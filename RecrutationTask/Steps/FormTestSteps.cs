namespace RecrutationTask.Steps
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using OpenQA.Selenium;

    using RecrutationTask.Pages;
    using RecrutationTask.Pages.Base;

    using TechTalk.SpecFlow;

    [Binding]
    public class FormTestSteps
    {
        private const string FormUrl = "https://app.bluealert.pl/ba/form/formularz-testowy";

        private BasicInformationPage basicInformationPage;

        private BasePage basePage;

        private IWebDriver driver;

        public FormTestSteps(ScenarioContext scenarioContext)
        {
            this.driver = scenarioContext.Get<IWebDriver>("driver");
            this.basePage = new BasePage(scenarioContext.Get<IWebDriver>("driver"));
            this.basicInformationPage = new BasicInformationPage(scenarioContext.Get<IWebDriver>("driver"));
        }

        [Given(@"The basic information page is open")]
        public void GivenTheBasicInformationPageIsOpen()
        {
            this.driver.Navigate().GoToUrl(FormUrl);
            this.basePage.WaitForLoadData();
            Assert.IsTrue(string.Equals(this.basePage.GetActiveStepName(), BasePageConstants.FirstFormPageName));
        }
        
        [When(@"I enter the name (.*)")]
        public void WhenIEnterTheName(string name)
        {
            this.basicInformationPage.Name.SendKeys(name);
        }
        
        [When(@"I enter the surname (.*)")]
        public void WhenIEnterTheSurname(string surname)
        {
            this.basicInformationPage.Surname.SendKeys(surname);
        }
        
        [When(@"I enter the email address (.*)")]
        public void WhenIEnterTheEmailAddress(string emailAddress)
        {
            this.basicInformationPage.Email.SendKeys(emailAddress);
        }
        
        [When(@"I enter the phone number (.*)")]
        public void WhenIEnterThePhoneNumber(string phoneNumber)
        {
            this.basicInformationPage.PhoneNumber.SendKeys(phoneNumber);
        }
        
        [When(@"I enter the pesel number (.*)")]
        public void WhenIEnterThePeselNumber(string pesel)
        {
            this.basicInformationPage.Pesel.SendKeys(pesel);
        }
        
        [When(@"I enter the id number (.*)")]
        public void WhenIEnterTheIdNumber(string idNumber)
        {
            this.basicInformationPage.IdNumber.SendKeys(idNumber);
        }
        
        [When(@"I enter the date of birth (.*)")]
        public void WhenIEnterTheDateOfBirth(string dateOfBirth)
        {
            this.basicInformationPage.DateOfBirth.SendKeys(dateOfBirth + Keys.Tab);
        }
        
        [When(@"I click Next button")]
        public void WhenIClickNextButton()
        {
            this.basePage.NextButton.Click();
        }
        
        [Then(@"The Consents page is opened")]
        public void ThenTheConsentsPageIsOpened()
        {
            this.basePage.WaitForLoadData();
            Assert.IsTrue(string.Equals(this.basePage.GetActiveStepName(), BasePageConstants.SecondFormPageName));
        }
    }
}
