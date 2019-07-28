using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.IE;

[assembly: Parallelize(Workers =0,Scope =ExecutionScope.MethodLevel)]
namespace EdgeDriverTest1
{
    [TestClass]
    public class EdgeDriverTest
    {
        // In order to run the below test(s), 
        // please follow the instructions from http://go.microsoft.com/fwlink/?LinkId=619687
        // to install Microsoft WebDriver.

        //private EdgeDriver _driver;
        private InternetExplorerDriver _driver;

        [TestInitialize]
        public void EdgeDriverInitialize()
        {
            // Initialize edge driver 
            var options = new EdgeOptions
            {
                
                PageLoadStrategy = PageLoadStrategy.Normal
            };
           
            _driver = new InternetExplorerDriver(@"C:\Users\ngoud\Desktop\D365TestAutomation\D365TestAutomation\EdgeDriverTest1\bin\Debug\");
            _driver.Manage().Window.Maximize();
            //_driver = new EdgeDriver(options);
        }

        [TestMethod]
        public void VerifyPageTitle()
        {
            // Replace with your own test logic
            _driver.Url = "https://kuvds.crm8.dynamics.com/";
            Assert.AreEqual("Bing", _driver.Title);
        }

        [TestMethod]
        public void VerifyPageTitle1()
        {
            // Replace with your own test logic
            _driver.Url = "www.bing.com";
            Assert.AreEqual("Bing", _driver.Title);
        }

        [TestMethod]
        public void VerifyPageTitle2()
        {
            // Replace with your own test logic
            _driver.Url = "www.google.com";
            Assert.AreEqual("Google", _driver.Title);
        }

        [TestCleanup]
        public void EdgeDriverCleanup()
        {
            //_driver.Quit();
        }
    }
}
