namespace RecrutationTask.Hooks
{
    using OpenQA.Selenium;

    using RecrutationTask.Helper;

    using TechTalk.SpecFlow;

    [Binding]
    public sealed class Hooks
    {
        /// <summary>
        /// The scenario context.
        /// </summary>
        private readonly ScenarioContext scenarioContext;

        /// <summary>
        /// The driver.
        /// </summary>
        private IWebDriver driver;

        public Hooks(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            this.driver = DriverFactory.ReturnDriver(DriverTypeEnum.Chrome);
            this.scenarioContext.Add("driver", this.driver);
            this.driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            this.driver.Close();
            this.driver.Dispose();
        }
    }
}
