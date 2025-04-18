
namespace TurnUpPortal_Specflow.Tests
{

    [Parallelizable]
    [TestFixture]
    public class Employee_Test : CommonDriver
    {

        [SetUp]

        public void SetUpSteps()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();

            LogIn_Page logInPageObj = new LogIn_Page();
            logInPageObj.LogInSteps(driver);

            Home_Page homePageObj = new Home_Page();
            homePageObj.GoToEmployeePage(driver);
        }

        [Test]

        public void CreateEmployeeRecord()
        {
            Employee_Page employeePageObj = new Employee_Page();
            employeePageObj.CreateEmployee(driver,"");

        }

       

        [TearDown]
        public void ClosingSteps()
        {
            driver.Quit();

        }

    }
}
