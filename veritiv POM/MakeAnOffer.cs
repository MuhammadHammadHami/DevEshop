using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace veritiv_POM
{
    class MakeAnOffer : BasePage
    {
        public void offer(string url, string number, string firstname, string lastname, string email, string OfferAmount)
        {
            By NavigateToProductName = By.XPath("//body/div[@id='wrapper']/div[@id='content']/div[1]/div[4]/div[1]/div[1]/div[1]/div[4]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[7]/div[1]/div[1]/div[1]");
            By OfferBTN = By.XPath("//input[@id='button-offer']");

            //  By OfferModal = By.Id("offerModal");
            By MobileNoTXT = By.XPath("//input[@id='phone_with_ddd']");

            By FirstNameTXT = By.XPath("//body/div[@id='wrapper']/div[@id='offerModal']/div[1]/div[1]/div[2]/form[1]/div[1]/div[2]/input[1]");
            By LastNameTXT = By.XPath("//body/div[@id='wrapper']/div[@id='offerModal']/div[1]/div[1]/div[2]/form[1]/div[1]/div[3]/input[1]");
            By EmailTXT = By.XPath("//body/div[@id='wrapper']/div[@id='offerModal']/div[1]/div[1]/div[2]/form[1]/div[1]/div[4]/input[1]");

            By OfferTXT = By.XPath("//input[@id='offer']");
            By RequestBTN = By.XPath("//button[@id='request']");
            By CloseBTN = By.XPath("//button[contains(text(),'Close')]");
            By Home = By.XPath("//header/div[3]/div[1]/div[1]/div[2]/div[1]/nav[1]/div[1]/div[2]/div[1]/div[1]/ul[1]/li[1]/a[1]/span[1]/strong[1]");

/*            driver.Url = url;

            Thread.Sleep(5000);

            driver.FindElement(By.ClassName("popup-title")).Click();
            driver.FindElement(By.XPath("//button[contains(text(),'×')]")).Click();
            Thread.Sleep(3000);*/

            IJavaScriptExecutor js = driver as IJavaScriptExecutor;

            js.ExecuteScript("window.scrollBy(0,1400);");
//            Thread.Sleep(5000);

            driver.FindElement(NavigateToProductName).Click();
            Thread.Sleep(5000);

            
            driver.FindElement(OfferBTN).Click();
            Thread.Sleep(5000);

            // driver.FindElement(OfferModal);
            driver.FindElement(By.ClassName("modal-title")).Click();
//            Thread.Sleep(3000);
            driver.FindElement(MobileNoTXT);
            if (driver.FindElement(MobileNoTXT).GetAttribute("") == null)
            {
                driver.FindElement(MobileNoTXT).SendKeys(number);
                driver.FindElement(MobileNoTXT).SendKeys(Keys.Tab);
            }

            Boolean fnisEnabled = driver.FindElement(FirstNameTXT).Displayed;
            Boolean lnisEnabled = driver.FindElement(LastNameTXT).Displayed;
            Boolean emailisEnabled = driver.FindElement(EmailTXT).Displayed;
//            Thread.Sleep(5000);

            if (fnisEnabled && lnisEnabled && emailisEnabled)
            {
                driver.FindElement(FirstNameTXT).SendKeys(firstname);
                driver.FindElement(LastNameTXT).SendKeys(lastname);
                driver.FindElement(EmailTXT).SendKeys(email);
            }

            driver.FindElement(OfferTXT).SendKeys(OfferAmount);
            Thread.Sleep(15000);

            driver.FindElement(RequestBTN).Click();
            Thread.Sleep(9000);

            driver.FindElement(CloseBTN).Click();
            Thread.Sleep(3000);
            driver.FindElement(Home).Click();
            Thread.Sleep(10000);






        }
    }
}
