

namespace TurnUpPortal_Specflow.Hooks
{
    [Binding]
    public sealed class DriverHooks : CommonDriver
    {
        // For additional details on Reqnroll hooks see https://go.reqnroll.net/doc-hooks

        [BeforeScenario(Order = 1)]
        public void BeforeScenarioWithTag()
        {
            var options = new ChromeOptions();
         //   options.AddArgument("--headless=new");
            options.AddArgument("--window-size=1920,1080");
            options.AddArgument("--disable-gpu");
            options.AddArgument("--no-sandbox");
           // options.AddArgument("--disable-dev-shm-usage");

            driver = new ChromeDriver(options);
            //driver.Manage().Window.Maximize();

            //driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
        }

     

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}