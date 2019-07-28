using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.UtilityHelper
{
    public class ComponentActions
    {
        public static void ClickButton(IWebDriver driver, string jQueryObject)
        {
            PageWaitTimings.WaitForJQueryLoaded(driver);
            PageWaitTimings.WaitForElementVisible(driver, jQueryObject);
            string script = string.Empty;
            if (!jQueryObject.StartsWith("$"))
            {                
                script = "$(" + jQueryObject + ").click()";
                Console.WriteLine(script);
                ((IJavaScriptExecutor)driver).ExecuteScript(script);
            }
            else
            {
                script = jQueryObject + ".click()";
                Console.WriteLine(script);
                ((IJavaScriptExecutor)driver).ExecuteScript(script);
            }
        }

        public static void ClickButton(IWebDriver driver, string jQueryObject, int indexValue)
        {
            PageWaitTimings.WaitForJQueryLoaded(driver);
            PageWaitTimings.WaitForElementVisible(driver, jQueryObject);
            string script = "$(" + jQueryObject + ")[" + indexValue + "].click()";            
                              Console.WriteLine(script);
                ((IJavaScriptExecutor)driver).ExecuteScript(script);
            
        }
        
    }
}
