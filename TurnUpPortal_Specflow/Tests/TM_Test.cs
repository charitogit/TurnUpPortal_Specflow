

namespace TurnUpPortal_Specflow.Tests
{
    [Parallelizable]
    [TestFixture]
    public class TM_Test : CommonDriver
    {

        //Setup
        [SetUp]
           
        public void SetUpSteps()

        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            //Login Steps
            LogIn_Page loginPageObj = new LogIn_Page();
            loginPageObj.LogInSteps(driver);

            //Go to TM Page
            Home_Page homePageObj = new Home_Page();
            homePageObj.GoToTMPage(driver);       
        }

        //Tests

        [Test, Order (1) , Description ("Checks if user can create a new Time & Material Record") ]

        public void CreateTimeRecord()
        {
            TM_Page tmPageObj = new TM_Page();
            tmPageObj.CreateTimeRecord(driver,"");

        }

        [Test , Order (2), Description ("Checks if user can update existing Time & Material Records") ]

        public void EditRecord()
        {
            TM_Page tmPageObj = new TM_Page();
            tmPageObj.EditRecord(driver,"","");


        }

        [Test, Order (3) , Description("Checks is user can delete existing record") ]

        public void DeleteRecord()
        {
            TM_Page tmPageObj = new TM_Page();
            tmPageObj.DeleteRecord(driver,"","");

        }

        //Teardown 

        [TearDown]

        public void ClosingSteps()
        {
            driver.Quit();

        }


    }
}
