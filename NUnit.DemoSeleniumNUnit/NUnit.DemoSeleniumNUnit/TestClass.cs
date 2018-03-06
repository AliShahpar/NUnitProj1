using NUnit.DemoSeleniumNUnit.PageActions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace NUnit.DemoSeleniumNUnit
{
    [TestFixture]
    [Parallelizable]
    class TestClass
    {
        /* [Test]
        public void TestMethod()
        {
            IWebDriver driver = new ChromeDriver();
            CreateProfile_PageAction profileActionObject = new CreateProfile_PageAction();
            driver.Navigate().GoToUrl("https://www.ediblearrangements.com/MyAccount/CreateProfile.aspx");
            Task.Delay(1500).Wait();

            profileActionObject.EnterEmailAddress(driver, "test@gmail.com");

            // Quit the chrome driver
            driver.Quit();
        } */


        [TestFixture]
        [Parallelizable]
        public class ChromeTesting : Hooks
        {
            // class constructor 
            public ChromeTesting() : base(BrowserType.Chrome)
            {
                
            }

            // this is a test method 
            [Test]
            public void MethodChrome()
            {
                Driver.Navigate().GoToUrl("https://m.ediblearrangements.com/?showteststore=1");
            }
        }


        [TestFixture]
        [Parallelizable]
        public class FireFoxTesting : Hooks
        {
            // class constructor 
            public FireFoxTesting() : base(BrowserType.IE) // call Chrome instead of Firefox for time being
            {

            }

            // this is a test method 
            [Test]
            public void MethodFireFox()
            {
                Driver.Navigate().GoToUrl("https://m.ediblearrangements.com/?showteststore=1");

            }
        }

    }
}
