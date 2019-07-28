using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.UtilityHelper
{
    public class PageWaitTimings
    {
        public static void WaitForPageLoad(IWebDriver driver)
            {
            
            WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));            
            webDriverWait.Until(drv => ((IJavaScriptExecutor)drv).ExecuteScript("return document.readyState").Equals("complete"));
            
            }

        public static void WaitForElementVisible(IWebDriver driver, string jQueryElement)
        {

            //eg : $(element).is(":visible");
            WaitForPageLoad(driver);
            WaitForJQueryLoaded(driver);
            WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            // bool elementToBeVisible = false;
            string script = string.Empty;
            if (!jQueryElement.StartsWith("$"))
            {
                script = "$(" + jQueryElement + ").length";
                Console.WriteLine(script);
                webDriverWait.Until(drv => Convert.ToInt32(((IJavaScriptExecutor)drv).ExecuteScript("return $(" + jQueryElement + ").length")) > 0);
                webDriverWait.Until(drv => Convert.ToBoolean(((IJavaScriptExecutor)driver).ExecuteScript("return $(" + jQueryElement + ").is(\":visible\")")) == true) ;
                Console.WriteLine(script + " " + Convert.ToBoolean(((IJavaScriptExecutor)driver).ExecuteScript("return $(" + jQueryElement + ").is(\":visible\")")));
            }
            else
            {
                try
                {
                    script = jQueryElement + ".length";
                    Console.WriteLine((script).ToString());
                    webDriverWait.Until(drv => Convert.ToInt32(((IJavaScriptExecutor)drv).ExecuteScript(script)) > 0);
                    webDriverWait.Until(drv => Convert.ToBoolean(((IJavaScriptExecutor)driver).ExecuteScript("return " + jQueryElement + ").is(\":visible\")")) == true);
                }
                catch (Exception)
                {
                    script = jQueryElement;
                    Console.WriteLine("In Exception "+script);
                    //webDriverWait.Until(drv => Convert.ToInt32(((IJavaScriptExecutor)drv).ExecuteScript(script)) > 0);
                    //webDriverWait.Until(drv => Convert.ToBoolean(((IJavaScriptExecutor)driver).ExecuteScript("return " + jQueryElement + ".is(\":visible\")")) == true);

                }
            }
            //Func<IWebDriver, bool> waitForElement = new Func<IWebDriver, bool>((IWebDriver web) =>
            //{
            //    elementToBeVisible = (bool) ((IJavaScriptExecutor)driver).ExecuteScript("return $("+ jQueryElement + ").is(\":visible\")");
            //    return elementToBeVisible;
            //});

            Console.WriteLine(script);
        }

        public static void WaitForJQueryLoaded(IWebDriver driver)
        {
            WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            webDriverWait.Until(drv=>(bool)((IJavaScriptExecutor)(drv)).ExecuteScript("return window.jQuery != undefined && jQuery.active === 0")==true);
        }
    }
}
