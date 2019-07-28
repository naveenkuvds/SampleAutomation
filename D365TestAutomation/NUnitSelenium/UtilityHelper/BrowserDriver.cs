using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSelenium.UtilityHelper
{
    public class BrowserDriver
    {
        public static IWebDriver GetDriver()
        {
            ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--disable-extensions");
            options.AddArgument("start-maximized");
            options.AddArgument("disable-infobars");
            options.AddArgument("--blink-settings=imagesEnabled=false");


            IWebDriver driver = new ChromeDriver(options)
            {
                Url = "https://www.hotmail.com"
            };
            PageWaitTimings.WaitForPageLoad(driver);
            //PageWaitTimings.WaitForJQueryLoaded(driver);
            return driver;
    }
    }
}
