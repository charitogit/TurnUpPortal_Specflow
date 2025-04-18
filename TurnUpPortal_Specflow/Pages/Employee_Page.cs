
using OpenQA.Selenium.DevTools.V133.Overlay;
using System.Xml.Linq;

namespace TurnUpPortal_Specflow.Pages
{
    public class Employee_Page
    {

        public void CreateEmployee(IWebDriver driver, string enteredName)
        {

            Thread.Sleep(5000);
            IWebElement createButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createButton.Click();

            //Enter Name 
            IWebElement name = driver.FindElement(By.Id("Name"));
            name.Click();
            name.SendKeys(enteredName);

            //Enter User Name
            IWebElement username = driver.FindElement(By.Id("Username"));
            username.Click();
            username.SendKeys(enteredName);

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
            ElementExtensions.JsClick(driver, selectGroupRecord); 



            try
            {
                //click on Save
                Wait.WaitToBeClickable(driver, "Id", "SaveButton", 10);
                IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
                saveButton.Click();
            }

            catch (Exception e) 
            { 
            Assert.Fail(e.Message);
            }

            //ensure back to list button shows
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"container\"]/div/a", 20);
            IWebElement backToListButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));

            // Scroll the element into view
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView({block: 'center', inline: 'nearest'});", backToListButton);

            // Optional small pause to allow scroll to complete smoothly
            Thread.Sleep(3000); // or use an explicit wait instead
           
         
            backToListButton.Click();
        }

        public string GetNewEmployeeName (IWebDriver driver)
        {
            Thread.Sleep(5000);
            //Click on last record button  
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"usersGrid\"]/div[4]/a[4]/span", 30);
            IWebElement lastRecordButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span")); 
            lastRecordButton.Click();

            //check the last record employee name 
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]", 10);
            IWebElement lastRecordName = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            return lastRecordName.Text;

        }

     
        public void EditEmployee(IWebDriver driver,String name, string username, string contact, string password, string retypepassword, string isadmin, string vehicle) 
        
        {

            Thread.Sleep(5000);
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
            editButton.Click();

            //Enter Name 
            IWebElement nameTextbox= driver.FindElement(By.Id("Name"));
            nameTextbox.Click();
            nameTextbox.Clear();
            nameTextbox.SendKeys(name);

            //Enter User Name
            IWebElement usernameTextbox = driver.FindElement(By.Id("Username"));
            usernameTextbox.Click();
            usernameTextbox.Clear();
            usernameTextbox.SendKeys(username);

            //Enter Contact
            IWebElement contactTextbox = driver.FindElement(By.Id("ContactDisplay"));
            contactTextbox.Click();
            contactTextbox.Clear();
            contactTextbox.SendKeys(contact);

            //Enter Password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.Click();
            passwordTextbox.Clear();
            passwordTextbox.SendKeys(password);

            //Retype password
            IWebElement retypePasswordTextbox = driver.FindElement(By.Id("RetypePassword"));
            retypePasswordTextbox.Click();
            retypePasswordTextbox.Clear() ; 
            retypePasswordTextbox.SendKeys(retypepassword);

            IWebElement isadminSelected = driver.FindElement(By.Id("IsAdmin"));
            //Select as Admin
            if (isadmin == "True")
            {

                isadminSelected.Click();
            }
            else
            {
                isadminSelected.Clear();    

            }


                //Vehicle Option
            IWebElement vehicleTextbox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            vehicleTextbox.Click();
            vehicleTextbox.Clear();
            vehicleTextbox.SendKeys(vehicle);

            try
            {
                //click on Save
                Wait.WaitToBeClickable(driver, "Id", "SaveButton", 10);
                IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
                saveButton.Click();
            }

            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }

            //ensure back to list button shows
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"container\"]/div/a", 20);
            IWebElement backToListButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));

            // Scroll the element into view
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView({block: 'center', inline: 'nearest'});", backToListButton);

            // Optional small pause to allow scroll to complete smoothly
            Thread.Sleep(3000); // or use an explicit wait instead


            backToListButton.Click();


        }


        public void DeleteEmployee(IWebDriver driver,string name,string userName)
        {
            Thread.Sleep(3000);
            //Click on last record button  
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"usersGrid\"]/div[4]/a[4]/span", 30);
            IWebElement lastRecordButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            lastRecordButton.Click();

            //check the last record employee name  and username 
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]", 30);
            IWebElement lastRecordName = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

           // Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[2]", 30);
            IWebElement lastRecordUserName = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[2]"));



            if (lastRecordName.Text == name && lastRecordUserName.Text == userName)
            {
                //Proceed to delete record
                //Click on Delete button for last record
                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[2]")); 
                deleteButton.Click();

                //Click OK on Delete pop up
                driver.SwitchTo().Alert().Accept();

                //Check if record is deleted by going to the last record
                driver.Navigate().Refresh();
                Thread.Sleep(3000); 

            }

            else { Assert.Fail("Record to delete is not existing " + name + " " + userName); }


            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"usersGrid\"]/div[4]/a[4]/span", 30); 
            IWebElement lastRecordButtonPostDelete = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            lastRecordButtonPostDelete.Click();

            Thread.Sleep(3000);
        }




        public string GetEmployeeNameFromLastRow(IWebDriver driver)
        {
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]", 30);
            IWebElement lastRecordName = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
         
            return lastRecordName.Text; 
        }

        public string GetEmployeeUserNameFromLastRow(IWebDriver driver)
        {

            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[2]", 30);
            IWebElement lastRecordUserName = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[2]"));
         
            return lastRecordUserName.Text; 
        }


    }
}
