using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;
using static veritiv_POM.ExecutionClass;

namespace veritiv_POM
{
    public class BasePage
    {
        public static IWebDriver driver;

        public void SeleniumInit()
        {
//            var myDriver = new ChromeDriver();
            var myDriver = new FirefoxDriver();
            driver = myDriver;
/*            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("Registration.png", ScreenshotImageFormat.Png); */ 
        }
    }
}