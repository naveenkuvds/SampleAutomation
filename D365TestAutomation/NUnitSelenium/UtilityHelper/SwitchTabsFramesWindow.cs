using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.UtilityHelper
{
    public class SwitchTabsFramesWindow
    {
        public static IWebDriver SwithcToNewWindow(IWebDriver driver)
        {            
            return driver.SwitchTo().Window(driver.WindowHandles[1]);
        }

        public static IWebDriver SwitchToFrame(IWebDriver driver, string frameName)
        {
            return driver.SwitchTo().Frame(frameName);
        }
    }
}
