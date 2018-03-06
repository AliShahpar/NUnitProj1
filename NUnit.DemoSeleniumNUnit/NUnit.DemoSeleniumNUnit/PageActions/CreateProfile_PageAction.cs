using NUnit.DemoSeleniumNUnit.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace NUnit.DemoSeleniumNUnit.PageActions
{
    class CreateProfile_PageAction
    {
        public CreateProfile createprofileObject = new CreateProfile();

        // this will enter the email address in the email address field
        public void EnterEmailAddress(IWebDriver driver, string str_email)
        {
            driver.FindElement(createprofileObject.EmailAddress).SendKeys(str_email);
        }
    }
}
