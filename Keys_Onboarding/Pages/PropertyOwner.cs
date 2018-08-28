using Keys_Onboarding.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using static Keys_Onboarding.Global.CommonMethods;


namespace Keys_Onboarding
{
    public class PropertyOwner
    {
        public PropertyOwner()
        {
            PageFactory.InitElements(Global.Driver.driver, this);
        }

        #region WebElements Definition
        //Define Owners tab
        //[FindsBy(How =How.XPath,Using = "/html/body/nav/div/ul/li[2]/a")]
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div[1]")]
        private IWebElement Ownertab { set; get; }

        //Define Properties page
        //[FindsBy(How = How.XPath, Using = "/html/body/nav/div/ul/li[2]/ul/li[1]/a")]
        [FindsBy(How = How.XPath,Using = "/html/body/div[1]/div/div[2]/div[1]/div/a[1]")]
        private IWebElement PropertiesPage { set; get; }

        //Define search bar        
        [FindsBy(How = How.XPath, Using = "//*[@id='searchId']")]
        [FindsBy(How = How.XPath, Using = "//*[@id='SearchBox']")]
        private IWebElement SearchBar { set; get; }

        //Define search button
        
        [FindsBy(How = How.XPath, Using = "//*[@id='icon-submitt']/form/div/div/button/span")]
        private IWebElement SearchButton { set; get; }

        #endregion

        public void Common_methods()
        {
            Global.Driver.wait(5);
            //Click on the Owners tab
            Ownertab.Click();

            //Select properties page
            PropertiesPage.Click();
        }

        internal void SearchAProperty()
        {
            try
            {
                //Calling the common methods
                Common_methods();
                Driver.wait(5);

                //Enter the value in the search bar
                SearchBar.SendKeys("TestingProperty");
                Global.Driver.wait(5);

                //Click on the search button
                SearchButton.Click();
                Driver.wait(5);

                string ExpectedValue = "TestingProperty";
                string ActualValue = Global.Driver.driver.FindElement(By.XPath("//*[@id='mainPage']/div[4]/div[1]/div/div/div[2]/div[2]/div[1]/div[1]/div[1]")).Text;

                //Assert.AreEqual(ExpectedValue, ActualValue);
                if (ExpectedValue == ActualValue)
                                    
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Test Passed, Search successfull");
                
                else
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Test Failed, Search Unsuccessfull");

            }

            catch(Exception e)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Test Failed, Search Unsuccessfull",e.Message);
            }
         }
    }
}