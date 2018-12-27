using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNGIntegrationDemo
{
    class ExpediaSearchPage
    {
        public static IWebElement element = null;

        public static void GetFlyingFrom(IWebDriver driver)
        {
            element = driver.FindElement(By.Id("flight-origin-flp"));
		    element.Clear();
		    element.SendKeys("SEA");
	    }

        public static void GetFlyingTo(IWebDriver driver)
        {
            element = driver.FindElement(By.Id("flight-destination-flp"));
            element.Clear();
            element.SendKeys("LAX");
        }


        public static void GetDeparting(IWebDriver driver)
        {
            element = driver.FindElement(By.Id("flight-departing-flp"));
            element.SendKeys("12/25/2018");

        }

        public static void GetReturning(IWebDriver driver)
        {
            element = driver.FindElement(By.Id("flight-returning-flp"));
            element.Clear();
            element.SendKeys("03/04/2019");
        }

        public static void GetTravellers(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//div[@class='menu-bar gcw-travel-selector-wrapper']//button[contains(@class,'gcw-traveler-amount-select')]"));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
        }


        public static void GetTravellersCount(IWebDriver driver)
        {
            GetTravellers(driver);
            //element = driver.findElement(By.xpath("//div[@class='traveler-selector-sinlge-room-data traveler-selector-room-data']"));
            element = driver.FindElement(By.XPath("//div[@class='traveler-selector-sinlge-room-data traveler-selector-room-data']//span[contains(text(),'Add Adult')]//parent::button"));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            action.MoveToElement(element).Click().Perform();
            action.MoveToElement(element).Click().Perform();
            action.MoveToElement(element).Click().Perform();

        }


        public static void SubmitButton(IWebDriver driver)
        {
            element = driver.FindElement(By.XPath("//div[@id='f-fh-msg-tooltip-flp']//preceding-sibling::label/button"));
            element.Click();
        }

}
}
