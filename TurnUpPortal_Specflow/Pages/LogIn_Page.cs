

namespace TurnUpPortal_Specflow.Pages
{
    public class LogIn_Page
    {
        public void LogInSteps(IWebDriver driver)
        {
            //Identify the UserName textbox and Enter User Name
            Wait.WaitToBeVisible(driver, "Id", "UserName", 10);
            IWebElement userNameTextBox = driver.FindElement(By.Id("UserName"));
            userNameTextBox.SendKeys("hari");

            //Identify the Password textbox and Enter Password
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("12341234");

            //Click on the LogIn Button
            IWebElement logInButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            logInButton.Click();

            //Check if Login is successful
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"logoutForm\"]/ul/li/a", 30);
            IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

            Assert.That(hellohari.Text == "Hello hari!", "Failed to login.");

        }

    }
}
