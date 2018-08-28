using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Threading;
using static Keys_Onboarding.Global.CommonMethods;

namespace Keys_Onboarding.Global
{
    internal class Login
    {      
        //create constructor
        public Login()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
              

        #region  Initialize Web Elements 
        // Finding the Email Field
        [FindsBy(How = How.XPath, Using = "//*[@id='UserName']")]
        private IWebElement Email { get; set; }

        // Finding the Password Field
        [FindsBy(How = How.XPath, Using = "//*[@id='Password']")]
        private IWebElement PassWord { get; set; }

        // Finding the Login Button
        //[FindsBy(How = How.XPath, Using = "//*[@id='sign_in']/div[3]/button[1]")]
        [FindsBy(How= How.XPath, Using = "//*[@id='sign_in']/div[1]/div[4]/button")]
        private IWebElement loginButton { get; set; }

        //Finding skip button
        [FindsBy(How = How.XPath,Using = "/html/body/div[5]/div/div[5]/a[1]")]
        private IWebElement skipButton { get; set; }

        #endregion

        internal void LoginSuccessfull()
        {
            // Populating the data from Excel
            ExcelLib.PopulateInCollection(Base.ExcelPath, "LoginPage");

            // Navigating to Login page using value from Excel
            Driver.driver.Navigate().GoToUrl(ExcelLib.ReadData(2, "Url"));

            // Sending the username 
            Email.SendKeys(ExcelLib.ReadData(2, "Email"));

            // Sending the password
            PassWord.SendKeys(ExcelLib.ReadData(2, "Password"));

            // Clicking on the login button
            loginButton.Click();

            //Clicking on skip button
            skipButton.Click();

            Thread.Sleep(3000);

            //Verification 
            //var expectedResult = "Owner's Dashboard";
            //implementing data driven framework

            var expectedResult = "";
            expectedResult = ExcelLib.ReadData(2,"TestData");
            var actualResult = Driver.driver.FindElement(By.XPath("//*[@id='main-content']/div/h1/div")).Text;

            Thread.Sleep(2000);
            if (expectedResult == actualResult)
            {
               Console.WriteLine("Test Pass");
                Thread.Sleep(1000);

            }
            else
            {
               Console.WriteLine("Test Fail");
                Thread.Sleep(1000);
            }
        }
    }
}