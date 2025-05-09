using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Reqnroll;
using TurnUpPortal_Specflow.Pages;
using TurnUpPortal_Specflow.Utilities;

namespace TurnUpPortal_Specflow.StepDefinition
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        [Given("I logged on to TurnUp successfully")]
        public void GivenILoggedOnToTurnUpSuccessfully()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            //Login Steps
            LogIn_Page loginPageObj = new LogIn_Page();
            loginPageObj.LogInSteps(driver);

          
        }

        [When("I navigate to Time & Material tab")]
        public void WhenINavigateToTimeMaterialTab()
        {
            //Go to TM Page
            Home_Page homePageObj = new Home_Page();
            homePageObj.GoToTMPage(driver);
        }

        [When("I create time & material record")]
        public void WhenICreateTimeMaterialRecord()
        {
            TM_Page tmPageObj = new TM_Page();
            tmPageObj.CreateTimeRecord(driver,"MARCH2025");
        }



        [Then("time & material records should be saved successfully")]
        public void ThenTimeMaterialRecordsShouldBeSavedSuccessfully()
        {
            //Assert wether created code is saved successfully 
            TM_Page tmPageObj = new TM_Page();
            string newCode = tmPageObj.GetNewCode(driver); 

            Assert.That(newCode, Is.EqualTo("MARCH2025"), "Test Failed: New Record is not created successfully.");

        }

        [When("I edit the {string} and {string} of existing record")]
        public void WhenIEditTheAndOfExistingRecord(string p0, string p1)
        {
            //Call Edit Time Record Method 
            TM_Page tmPageObj = new TM_Page();
            tmPageObj.EditRecord(driver,p0,p1);
        }

        [Then("record should be updated with new {string} and {string}")]
        public void ThenRecordShouldBeUpdatedWithNewAnd(string p0, string p1)
        {
            //Assert if time & record updated successfully here 
            TM_Page tmPageObj = new TM_Page();
            string editedCode = tmPageObj.GetEditedCode(driver);
            string editedDescription=tmPageObj.GetEditedDescription(driver);

            Assert.That(p0 == editedCode, "Code failed to edit.");
            Assert.That(p1 == editedDescription, "Description failed to edit");

        }

    }
}
