using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortal_Specflow.Pages;
using TurnUpPortal_Specflow.Utilities;

namespace TurnUpPortal_Specflow.Tests
{
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

        [Test]

        public void CreateTimeRecord()
        {
            TM_Page tmPageObj = new TM_Page();
            tmPageObj.CreateTimeRecord(driver);

        }

        [Test]

        public void EditRecord()
        {
            TM_Page tmPageObj = new TM_Page();
            tmPageObj.EditRecord(driver);


        }

        [Test]

        public void DeleteRecord()
        {
            TM_Page tmPageObj = new TM_Page();
            tmPageObj.DeleteRecord(driver);

        }

        //Teardown 

        [TearDown]

        public void ClosingSteps()
        {
            driver.Quit();

        }


    }
}
