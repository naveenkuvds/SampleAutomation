using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string className = Thread.CurrentThread.Name;
            string currentSourceCodeFilePath = new StackTrace(true).GetFrame(0).GetFileName();
            //IWebDriver Driver = 
            //System.Environment.
            TestContext.WriteLine(className);
            TestContext.WriteLine(this.GetType().Name);
            TestContext.WriteLine(currentSourceCodeFilePath);
            TestContext.WriteLine(Path.GetFileNameWithoutExtension(currentSourceCodeFilePath));
            IWebDriver chromeDriver = new ChromeDriver();
            
            ICapabilities chromeCapabilities = ((ChromeDriver)chromeDriver).Capabilities;
            Assert.Pass();
        }
    }
}