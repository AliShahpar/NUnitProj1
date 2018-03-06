using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;



namespace NUnit.DemoSeleniumNUnit
{
    enum BrowserType
    {
        Chrome,
        Firefox,
        IE
    }
     

    [TestFixture]
    class Hooks : Base
    {
        private BrowserType browsertypeObject;

        public Hooks(BrowserType str_browsertype)
         {
            browsertypeObject = str_browsertype;    
         }

        [SetUp]
        public void InitializeTest()
        {
            ChooseDriverInstance(browsertypeObject);
        }


        // this will choose webdriver based upon passed argument
        public void ChooseDriverInstance(BrowserType _browsertype)
        {
            if (_browsertype == BrowserType.Chrome)
            {
                Driver = new ChromeDriver();
            }
            else if (_browsertype == BrowserType.IE)
            {
                Driver = new InternetExplorerDriver();
            }
            else if(_browsertype == BrowserType.Firefox)
            {
                Driver = new FirefoxDriver();
            }
        }

    }
}
