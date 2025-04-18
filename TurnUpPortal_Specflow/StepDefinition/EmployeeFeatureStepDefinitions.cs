using System;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using Reqnroll;

namespace TurnUpPortal_Specflow.StepDefinition
{
    [Binding]
    public class EmployeeFeatureStepDefinitions : CommonDriver
    {
        [Given("I logged into TurnUp portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            LogIn_Page loginPageObj = new LogIn_Page();
            loginPageObj.LogInSteps(driver);

        }

        [When("I navigate to employee page")]
        public void WhenINavigateToEmployeePage()
        {
            Home_Page homePageObj = new Home_Page();
            homePageObj.GoToEmployeePage(driver);

        }

        [When("I create new employee {string} record")]
        public void WhenICreateNewEmployeeRecord(string name)
        {
            Employee_Page employeePageObj = new Employee_Page();
            employeePageObj.CreateEmployee(driver, name);
        }

        [Then("new employee {string} record should be saved successfully")]
        public void ThenNewEmployeeRecordShouldBeSavedSuccessfully(string name)
        {
            Employee_Page employeePageObj = new Employee_Page();
            string newName = employeePageObj.GetNewEmployeeName(driver);

            Assert.That(newName, Is.EqualTo(name), "Test Failed : New Employee is not created successfully");

        }


        [When("I edit {string},{string},{string},{string},{string},{string}and {string} of employee record")]
        public void WhenIEditAndOfEmployeeRecord(string p0, string p1, string p2, string p3, string p4, string p5, string p6)
        {
            //Go to last record of employee list
            Employee_Page employeePageObj = new Employee_Page();
            string employeeToEdit = employeePageObj.GetNewEmployeeName(driver);

            if (employeeToEdit.Contains("Peanut"))
            {

                employeePageObj.EditEmployee(driver, p0, p1, p2, p3, p4, p5, p6);

            }
            else

            { Assert.Fail("Recorde to update is not existing"); }
        }

        [Then("the {string},{string},{string},{string},{string},{string}and {string} of employee record should be updated successfully")]
        public void ThenTheAndOfEmployeeRecordShouldBeUpdatedSuccessfully(string p0, string p1, string p2, string p3, string p4, string @true, string bike)
        {
            //Assert here if record is updated successfully

            //Get value of last row
            Employee_Page employeePageObj = new Employee_Page();
            string updatedName = employeePageObj.GetNewEmployeeName(driver);


            //Assert success if last record updated 
            if (updatedName == p0)
            {
                Assert.Pass("Record updated successfully to " + p0);
            }

            else { Assert.Fail("Test Failed: Record is not updated successfully"); }

        }


        //Deletion of Employee Record

        [When("I delete the {string} and {string} employee record")]
        public void WhenIDeleteTheAndEmployeeRecord(string name, string username)
        {
            Employee_Page employeePageObj = new Employee_Page();
            employeePageObj.DeleteEmployee(driver, name, username);


        }

        [Then("{string} and {string} employee record should be deleted successfully")]
        public void ThenAndEmployeeRecordShouldBeDeletedSuccessfully(string name, string username)
        {
            //Assert here if deletion is successful 
            Employee_Page employeePageObj = new Employee_Page();
            string employeeName = employeePageObj.GetEmployeeNameFromLastRow(driver);
            string employeeUserName = employeePageObj.GetEmployeeUserNameFromLastRow(driver);



            if (employeeName != name && employeeUserName != username)
            {
                Assert.Pass(name + " and " + username + " deleted successfully.");
            }

            else
            {

                Assert.Fail("Test Failed :" + name + " and " + username + " still existing.Record is not  deleted successfully.");
            }






        }
    }

}