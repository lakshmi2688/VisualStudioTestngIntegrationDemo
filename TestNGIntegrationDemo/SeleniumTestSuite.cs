using log4net;
using log4net.Repository.Hierarchy;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNGIntegrationDemo
{
    class SeleniumTestSuite
    {

        IWebDriver driver;
        string baseUrl = "https://www.expedia.com/Flights";
        Logger log = (Logger)LogManager.GetLogger("SeleniumTestSuite");

        [SetUp]
        public void setUp()
        {
            driver = new ChromeDriver("C:\\Users\\Lakshmi\\Desktop\\Selenium\\Selenium drivers download\\chromedriver_win32");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test]
        public void test()
        {
            driver.Url = baseUrl;
            ExpediaSearchPage.GetFlyingFrom(driver);
            ExpediaSearchPage.GetFlyingTo(driver);
            ExpediaSearchPage.GetDeparting(driver);
            ExpediaSearchPage.GetReturning(driver);
            ExpediaSearchPage.GetTravellersCount(driver);
            ExpediaSearchPage.SubmitButton(driver);
        }


        [TearDown]
        public void tearDown()
        {
            driver.Quit();
        }

    }
}
