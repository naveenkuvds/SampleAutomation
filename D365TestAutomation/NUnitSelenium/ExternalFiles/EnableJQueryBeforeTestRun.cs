/* public class RunJquery
{

    WebDriver driver;
    JavascriptExecutor js;

    @FindBy(id= "lst-ib") WebElement googleTxtBox;

    @BeforeClass
    public void browserInstantiate()
    {
        //System.setProperty("webdriver.chrome.driver", System.getProperty("user.dir") + "\\chromedriver.exe");
        System.setProperty("webdriver.gecko.driver", System.getProperty("user.dir") + "\\geckodriver.exe");
        driver = new FirefoxDriver();
        //driver = new ChromeDriver();
        js = (JavascriptExecutor)driver;
        PageFactory.initElements(driver, this);
    }

    @Test
    public void getText() throws Exception
    {
        driver.get("http://google.com");
        verifyElementVisible(googleTxtBox);
    enablejQuery();
    System.out.println(js.executeScript("return $(\"div#_eEe\").text();"));
    }

public void enablejQuery() throws Exception
{
    String readyState = js.executeScript("return document.readyState").toString();
    System.out.println("Ready State: " + readyState);
    System.out.println("Is Jquery loaded......" + isjQueryLoaded());
        if(!isjQueryLoaded()) {
        URL jqueryUrl = Resources.getResource("jquery-3.1.1.min.js");
        System.out.println(jqueryUrl.getPath());
        String jqueryText = Resources.toString(jqueryUrl, Charsets.UTF_8);
        js.executeScript(jqueryText);
    }
    System.out.println("Is Jquery loaded......" + isjQueryLoaded());
}

public Boolean isjQueryLoaded() throws Exception
{
        return (Boolean) js.executeScript("return !!window.jQuery;");
}

}

*/
