using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keys_Onboarding.Pages
{
    class Tenant
    {
        public Tenant()
        {
            PageFactory.InitElements(Global.Driver.driver, this);
        }

        //Define web elemenets from tenants page
        //.....................................
        public void Common_methods()
        {
            Global.Driver.wait(5);
            //Click on the Owners tab
            //Ownertab.Click();

            //Select properties page
            //PropertiesPage.Click();
        }

        //write method for adding Tenant--> MyRequest
        //internal void methodName()
    }
}
