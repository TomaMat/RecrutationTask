namespace RecrutationTask.Helper
{
    using System;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Edge;
    using OpenQA.Selenium.Firefox;

    public static class DriverFactory
    {
        /// <summary>
        /// Return driver
        /// </summary>
        /// <param name="driverType"></param>
        /// <returns></returns>
        public static IWebDriver ReturnDriver(DriverTypeEnum driverType)
        {
            IWebDriver driver;
            switch (driverType)
            {
                case DriverTypeEnum.Chrome:
                    driver = new ChromeDriver();
                    break;
                case DriverTypeEnum.Firefox:
                    driver = new FirefoxDriver();
                    break;
                case DriverTypeEnum.Edge:
                    driver = new EdgeDriver();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(driverType), driverType, null);
            }

            return driver;
        }
    }
}
