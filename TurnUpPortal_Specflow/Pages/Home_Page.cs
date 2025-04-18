

namespace TurnUpPortal_Specflow.Pages
{
    public class Home_Page
    {
        public void GoToTMPage (IWebDriver driver)
        {


            // Navigate to Time & Material Tab
            Wait.WaitToBeVisible(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/a", 10);
            IWebElement administrationButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationButton.Click();

            //Click on Time & Material Tab
            IWebElement timeMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeMaterialOption.Click();

        }

        public void  GoToEmployeePage(IWebDriver driver)
        {
            // Navigate to Administration Tab
            IWebElement administrationButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationButton.Click();

            //Click on Employee tab
            IWebElement employeeOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            employeeOption.Click();
        }

    }
}
