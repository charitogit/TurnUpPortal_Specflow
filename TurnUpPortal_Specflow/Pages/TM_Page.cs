using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortal_Specflow.Utilities;

namespace TurnUpPortal_Specflow.Pages
{
    public class TM_Page
    {

       public void CreateTimeRecord(IWebDriver driver)
        {
            //Create New Record
            IWebElement createButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createButton.Click();
            Wait.WaitToBeVisible(driver, "Xpath", "//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]", 5);

            IWebElement typeCodeOption = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typeCodeOption.Click();

            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"TypeCode_listbox\"]/li[1]", 5);
            IWebElement materialOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[1]"));
            materialOption.Click();

            //Enter Code
            IWebElement code = driver.FindElement(By.Id("Code"));
            code.Click();
            code.SendKeys("MARCH2025");

            //Enter Descritpion
            IWebElement descriptionText = driver.FindElement(By.Id("Description"));
            descriptionText.Click();
            descriptionText.SendKeys("Test Create New Material Record");

            //Enter Price
            IWebElement priceTag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTag.Click();

            Wait.WaitToBeClickable(driver, "Id", "Price", 5);
            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("100");

            //Click Save 
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(5000);

            try
            {

                Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 30); ////*[@id="tmsGrid"]/div[4]/a[4]/span
                IWebElement lastRecordButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
                lastRecordButton.Click();
            }

            catch (Exception)

            {
                Assert.Fail("last record button not located");

            }
            //Check last record of the data table

            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]", 30);
            IWebElement lastRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(5000);
            Assert.That(lastRecord.Text, Is.EqualTo("MARCH2025"), "Test Failed: New Record is not created successfully.");


        }

        public void EditRecord(IWebDriver driver)
        {
            //EDIT A RECORD
            //Click on last record button
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 30);
            IWebElement lastRecordButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));////*[@id="tmsGrid"]/div[4]/a[4]/span
            lastRecordButton.Click();

            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]", 30);


            //Click Edit in last record from the list
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();



            //Select Code
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]", 5);
            IWebElement codeOption = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            codeOption.Click();


            //Select Time
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"TypeCode_listbox\"]/li[2]", 5);
            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeOption.Click();

            //Enter Code
            IWebElement codeText = driver.FindElement(By.Id("Code"));
            codeText.Click();
            codeText.Clear();
            codeText.SendKeys("APRIL2025");

            //Enter Description
            IWebElement descriptionText = driver.FindElement(By.Id("Description"));
            descriptionText.Click();
            descriptionText.Clear();
            descriptionText.SendKeys("APRIL2025");

            //Enter Price
            IWebElement priceTag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTag.Click();
            Wait.WaitToBeClickable(driver, "Id", "Price", 5);

            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.Clear();

            priceTag.Click();
            Thread.Sleep(1500);
            priceTextbox.SendKeys("$200.00");

            //Click Save 
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            try
            {
                //Check if record is updated successfully
                Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 10);
                IWebElement lastRecordButtonAfterSave = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
                lastRecordButtonAfterSave.Click();
            }
            catch (Exception)


            {
                Assert.Fail("Cannot locate last record button");

            }

            Thread.Sleep(5000);
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]", 30);
            IWebElement lastCodeRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]", 30);
            IWebElement lastDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));


            Assert.That(lastCodeRecord.Text == "APRIL2025", "Code failed to edit.");
            Assert.That(lastDescription.Text == "APRIL2025", "Description failed to edit");

        }

        public void DeleteRecord(IWebDriver driver)

        {
            //DELETE A RECORD

            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 30); 

            try
            {
                Thread.Sleep(5000);
                //Click on last record button
                Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 30); ////*[@id="tmsGrid"]/div[4]/a[4]/span
                IWebElement lastRecordButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
                lastRecordButton.Click();

            }

            catch (Exception ex)

            {

                Assert.Fail("Last Record button not found" + ex.Message);

            }

           // Validate first if record to be deleted is existing
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]", 30); ////*[@id="tmsGrid"]/div[3]/table/tbody/tr[6]/td[1]

            Thread.Sleep(5000);

            try
            { 
                IWebElement recordToDelete = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));


                if (recordToDelete.Text == "APRIL2025")
                {

                    //Click on Delete button for last record
                    IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
                    deleteButton.Click();

                    //Click OK on Delete pop up
                    driver.SwitchTo().Alert().Accept();

                    //Check if record is deleted by going to the last record
                    driver.Navigate().Refresh();

                }

                else
                {
                    Assert.Fail("Record to be deleted is not existing.");
                }

            }

            catch (Exception ex) { Assert.Fail("record to delete is not found" + ex.Message); }

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 30);
            IWebElement lastRecordButtonPostDelete = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastRecordButtonPostDelete.Click();
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]", 30);

            IWebElement code = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(5000);

            if (code.Text != "APRIL2025")
            {
                Assert.Pass("Record deleted successfully.");
            }
            else
            {
                Assert.Fail("Failed to delete record.");
            }

        }

    }
}
