using Keys_Onboarding.Global;
using Keys_Onboarding.Test;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Keys_Onboarding.Global.CommonMethods;

namespace Keys_Onboarding.Pages
{
    class MyTenant
    {
        public MyTenant()
        {
            PageFactory.InitElements(Global.Driver.driver, this);
        }

        //Define web elemenets from tenants page
        //Identify "Tenant" dropdown
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div[1]")]
        private IWebElement TenantDropdown { set; get; }

        //Identify "MyRentals" option
        [FindsBy(How =How.XPath,Using = "/html/body/div[1]/div/div[2]/div[1]/div/a[1]")]
        private IWebElement TenantDropdownMyRentalsOption { set; get; }

        //Identify "My Requests" option
        [FindsBy(How =How.XPath,Using = "/html/body/div[1]/div/div[2]/div[1]/div/a[3]")]
        private IWebElement TenantDropdownMyRequestsOption { set; get; }

        //Identify dropdown list of first record
        [FindsBy(How =How.XPath,Using = "//*[@id='mainPage']/table/tbody/tr[1]/td[6]/div/i")]
        private IWebElement FirstRecordDropdownList { set; get; }

        //Identify "Send Request" option from first record dropdown list
        [FindsBy(How =How.XPath,Using = "//*[@id='mainPage']/table/tbody/tr[1]/td[6]/div/div/div[1]")]
        private IWebElement FirstRecordDropdownListSendRequestOption { set; get; }

        //Identify "Message" box from rental request page
        [FindsBy(How =How.XPath,Using = "//*[@id='RequestPage']/div[2]/form/fieldset/div[3]/div/div/textarea")]
        private IWebElement MessageBoxFromRentalRequestPage { set; get; }

        //Identify "Submit" button from rental request page
        [FindsBy(How =How.XPath,Using = "//*[@id='RequestPage']/div[2]/form/fieldset/div[6]/div/button[1]")]
        private IWebElement SubmitButtonFromRentalRequestPage { set; get; }

        //Identify "Message" column of first record Tenant-->My Requests page
        //[FindsBy(How =How.XPath,Using = "//*[@id='mainPage']/table/tbody/tr[1]/td[3]")]
        //private IWebElement MessageColumnFirstRecordMyRequestPage { set; get; }


        public void Common_methods()
        {
            Global.Driver.wait(5);
            //Click on the Tenant dropdown
            TenantDropdown.Click();

            //Select MyRentals option 
            TenantDropdownMyRentalsOption.Click();
        }

        //write method for adding Tenant--> MyRequest
        internal void tenantMyRentals()
        {
            //Calling the common methods
            Common_methods();
            Driver.wait(5);

            //click on dropdown list of first record
            FirstRecordDropdownList.Click();
            Thread.Sleep(1000);

            //click on send request option
            FirstRecordDropdownListSendRequestOption.Click();
            Thread.Sleep(1000);

            //Click on Message box
            MessageBoxFromRentalRequestPage.Click();
            Thread.Sleep(1000);

            //Type in the message or request in "Message Box"
            var compareText1 = ExcelLib.ReadData(3, "TestData");
            MessageBoxFromRentalRequestPage.SendKeys(compareText1);

            //Click on Submit button
            SubmitButtonFromRentalRequestPage.Click();

            //Verification
            //refresh driver and click on Tenant Dropdown
            //Driver.driver.Navigate().Refresh();
            Thread.Sleep(2000);
           
            TenantDropdown.Click();

            //Select "My Requests" option
            TenantDropdownMyRequestsOption.Click();

            //compare the content "Tenant-->My Rentals--> First Record--> Send Request-->Message" with "Tenant-->My Requests-->First Record-->Message"
            var compareText2 = Driver.driver.FindElement(By.XPath("//*[@id='mainPage']/table/tbody/tr[1]/td[3]")).Text;

            //refresh browser
            Driver.driver.Navigate().Refresh();
            Thread.Sleep(3000);



            //Compare text
            if (compareText1==compareText2)
            {
                Console.WriteLine("Test Pass");
                //Taking screenshot of Tenant-->My Reuests--> First record
                Global.CommonMethods.SaveScreenShotClass.SaveScreenshot(Driver.driver, "Verify Description");
            }

            
        }
       
    }
}
