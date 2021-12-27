namespace RecrutationTask.Pages
{
    using OpenQA.Selenium;

    using RecrutationTask.Pages.Base;

    using SeleniumExtras.PageObjects;

    public class BasicInformationPage : BasePage
    {
        public BasicInformationPage(IWebDriver driver) : base(driver)
        {
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [FindsBy(How = How.Id, Using = BasicInformationPageConstants.NameId)]
        public IWebElement Name { get; set; }

        /// <summary>
        /// Gets or sets the surname.
        /// </summary>
        [FindsBy(How = How.Id, Using = BasicInformationPageConstants.SurnameId)]
        public IWebElement Surname { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        [FindsBy(How = How.Id, Using = BasicInformationPageConstants.EmailId)]
        public IWebElement Email { get; set; }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        [FindsBy(How = How.Id, Using = BasicInformationPageConstants.PhoneNumberId)]
        public IWebElement PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the PESEL number.
        /// </summary>
        [FindsBy(How = How.Id, Using = BasicInformationPageConstants.PeselId)]
        public IWebElement Pesel { get; set; }

        /// <summary>
        /// Gets or sets the id number.
        /// </summary>
        [FindsBy(How = How.Id, Using = BasicInformationPageConstants.IdNumberId)]
        public IWebElement IdNumber { get; set; }

        /// <summary>
        /// Gets or sets the date of birth.
        /// </summary>
        [FindsBy(How = How.Id, Using = BasicInformationPageConstants.DateOfBirthId)]
        public IWebElement DateOfBirth { get; set; }
    }
}
