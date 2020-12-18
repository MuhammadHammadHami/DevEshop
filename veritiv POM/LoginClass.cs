using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using static veritiv_POM.ExecutionClass;

namespace veritiv_POM
{
    public class LoginPage : BasePage
    {
        public void login(string url, string MobileNo, string password)
        {
            By NavigateToLoginTXT = By.XPath("//header/div[2]/div[1]/div[1]/div[3]/ul[1]/li[2]/a[1]");
            By MobileNoTXT = By.XPath("//input[@id='input-phone']");
            By passwordTXT = By.XPath("//input[@id='input-password']");
            By loginBTN = By.XPath("//body/div[@id='wrapper']/div[4]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/input[1]");

            By NavigateToHomeTXT = By.XPath("//header/div[3]/div[1]/div[1]/div[2]/div[1]/nav[1]/div[1]/div[2]/div[1]/div[1]/ul[1]/li[1]/a[1]/span[1]/strong[1]");
            //By Popup = By.XPath("//button[contains(text(),'×')]");

            driver.Url = url;

            driver.FindElement(By.ClassName("popup-title")).Click();
            driver.FindElement(By.XPath("//button[contains(text(),'×')]")).Click();

            /*            driver.SwitchTo().ParentFrame();
             //           driver.SwitchTo().Frame(driver.FindElement(By.XPath("//body/div[@id='wrapper']/div[@id='content']/div[@id='container-module-newletter']/div[@id='so_newletter_custom_popup']/div[1]")));
                        driver.FindElement(Popup).Click();
                        driver.SwitchTo().DefaultContent();*/

            driver.FindElement(NavigateToLoginTXT).Click();
            driver.FindElement(MobileNoTXT).SendKeys(MobileNo);
            driver.FindElement(passwordTXT).SendKeys(password);
            driver.FindElement(loginBTN).Click();

            driver.FindElement(NavigateToHomeTXT).Click();




        }
    }
}