using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnUpPortal_Specflow.Utilities
{
    public  class Wait
    {
        public static void WaitToBeVisible(IWebDriver driver, string locType, string locValue, int seconds)

        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));

            if (locType == "XPath")

            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locValue)));
            }

            if (locType == "Id")

            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.Id(locValue)));
            }


        }

        public static void WaitToBeClickable(IWebDriver driver, string locType, string locValue, int seconds)

        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));

            if (locType == "XPath")

            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locValue)));
            }

            if (locType == "Id")

            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(locValue)));
            }


        }
    }
}
