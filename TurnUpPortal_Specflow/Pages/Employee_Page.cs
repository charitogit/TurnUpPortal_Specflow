using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortal_Specflow.Utilities;

namespace TurnUpPortal_Specflow.Pages
{
    public class Employee_Page
    {

        public void CreateEmployee(IWebDriver driver)
        {
            IWebElement createButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createButton.Click();

            //Enter Name 
            IWebElement name = driver.FindElement(By.Id("Name"));
            name.Click();
            name.SendKeys("Charito");

            //Enter User Name
            IWebElement username = driver.FindElement(By.Id("Username"));
            username.Click();
            username.SendKeys("Charito");

            //Enter Contact
            IWebElement contact = driver.FindElement(By.Id("ContactDisplay"));
            contact.Click();
            contact.SendKeys("12345678");

            //Enter Password
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.Click();
            password.SendKeys("MyP@ssw0rd");

            //Retype password
            IWebElement retypePassword = driver.FindElement(By.Id("RetypePassword"));
            retypePassword.Click();
            retypePassword.SendKeys("MyP@ssw0rd");

            //Select as Admin
            IWebElement isAdmin = driver.FindElement(By.Id("IsAdmin"));
            isAdmin.Click();


            //Vehicle Option
            IWebElement vehicle = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            vehicle.Click();
            vehicle.SendKeys("Car");

            //Group Option
            IWebElement group = driver.FindElement(By.XPath("/html/body/div[4]/form/div/div[8]/div/div/div[1]"));
            group.Click();

            //select first group option from dropdown
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"groupList_listbox\"]/li[1]", 5);
            IWebElement selectGroupRecord = driver.FindElement(By.XPath("//*[@id=\"groupList_listbox\"]/li[1]"));
            selectGroupRecord.Click();

            //click on Save
            Wait.WaitToBeClickable(driver, "Id", "SaveButton", 10);
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

        }
        public void EditEmployeed(IWebDriver driver) 
        
        {
        }

        public void DeleteEmployeed(IWebDriver driver)
        {

        }

    }
}
