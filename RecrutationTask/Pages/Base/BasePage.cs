namespace RecrutationTask.Pages.Base
{
    using System;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    using SeleniumExtras.PageObjects;

    public class BasePage
    {
        /// <summary>
        ///     The driver.
        /// </summary>
        protected readonly IWebDriver Driver;

        public BasePage(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        /// <summary>
        /// Gets or sets Next button.
        /// </summary>
        [FindsBy(How = How.Id, Using = BasePageConstants.NextButtonId)]
        public IWebElement NextButton { get; set; }

        /// <summary>
        /// Gets or sets Active step.
        /// </summary>
        [FindsBy(How = How.XPath, Using = BasePageConstants.ActiveStepXpath)]
        public IWebElement ActiveStep { get; set; }

        /// <summary>
        /// The wait for element.
        /// </summary>
        /// <param name="by">
        /// The by.
        /// </param>
        /// <param name="timeoutSeconds">
        /// The timeout Seconds.
        /// </param>
        public void WaitForElementToVanish(By by, int timeoutSeconds = 20)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(timeoutSeconds));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.InvisibilityOfElementLocated(by));
            }
            catch (NoSuchElementException)
            {
            }
        }

        /// <summary>
        /// The wait for load data.
        /// </summary>
        public void WaitForLoadData()
        {
            this.WaitForElementToVanish(By.XPath("//header//div[@class='stepProgress']"));
        }

        /// <summary>
        /// Gets active step name.
        /// </summary>
        /// <returns></returns>
        public string GetActiveStepName()
        {
            var element = this.ActiveStep;
            return element.FindElement(By.ClassName("step-progress__item-name")).Text;
        }
    }
}
