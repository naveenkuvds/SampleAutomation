// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using NUnitSelenium.UtilityHelper;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitSelenium
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
            IWebDriver driver = BrowserDriver.GetDriver();
            IWebElement signInButton = driver.FindElements(By.ClassName("linkButtonSigninHeader"))[1];
            signInButton.Click();

            IWebElement loginTextBox = driver.FindElement(By.Id("i0116"));
            loginTextBox.SendKeys("naveenkuvds@hotmail.com");
            IWebElement nextButton = driver.FindElement(By.Id("idSIButton9"));
            nextButton.Click();
            IWebElement passwordTextBox = driver.FindElement(By.Id("i0118"));
            passwordTextBox.SendKeys("Mlalg786*");
            
            IWebElement submitButton = driver.FindElement(By.Id("idSIButton9"));
            Thread.Sleep(1000);            
            //PageWaitTimings.WaitForPageLoad(driver);
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("document.getElementById('idSIButton9').click()");
            Thread.Sleep(3000);
            ComponentActions.ClickButton(driver, "'button[title=\"Applications\"]'");
            ComponentActions.ClickButton(driver, "'a[aria-label=\"Excel\"]'",0);
            Thread.Sleep(3000);
            SwitchTabsFramesWindow.SwithcToNewWindow(driver);
            ComponentActions.ClickButton(driver, "$('#template_blank')");
            Thread.Sleep(3000);
            PageWaitTimings.WaitForPageLoad(driver);
            SwitchTabsFramesWindow.SwitchToFrame(driver, "sdx_ow_iframe");
            ComponentActions.ClickButton(driver, "$('#id__11')");
            //driver.FindElement(By.XPath("//*[@id='id__11']")).Click();
            //((IJavaScriptExecutor)driver).ExecuteScript("for (i = 0; i < document.getElementsByTagName(\"span\").length; i++){if (document.getElementsByTagName(\"span\")[i].innerText === \"Data\") {document.getElementsByTagName(\"span\")[i].click();}};");
            Thread.Sleep(10000);
            
            driver.Quit();
        }
    }
}
