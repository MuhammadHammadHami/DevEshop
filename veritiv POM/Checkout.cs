using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace veritiv_POM
{
    class Checkout : BasePage
    {
        public void CheckOut(string number, string firstname, string lastname, string email, string address, string city)
        {
            By HoverOnCartBTN = By.XPath("//div[@id='cart']  ");
            By CheckoutBTN = By.XPath("//a[contains(text(),'Checkout')]");
            By MobileNoTXT = By.XPath("//input[@id='input-payment-telephone']");

            By FirstNameTXT = By.XPath("//input[@id='input-payment-firstname']");
            By LastNameTXT = By.XPath("//input[@id='input-payment-lastname']");
            By EmailTXT = By.XPath("//input[@id='input-payment-email']");

            By DeliveryMethodDSD = By.XPath("//body/div[@id='wrapper']/div[@id='checkout-checkout']/div[1]/div[1]/div[1]/form[1]/div[4]/div[2]/div[1]/fieldset[1]/div[1]/div[1]/div[1]/label[3]/input[1]");
            By AddressTXT = By.XPath("//input[@id='input-payment-address-1']");
            By CityTXT = By.XPath("//input[@id='input-payment-city']");
            By ConfirmBTN = By.XPath("//input[@id='confirm']");
            By Confirmation = By.XPath("//h1[contains(text(),'Your order has been placed!')]");

            //Actions ac = new Actions(driver);
            // IWebElement CartElement = driver.FindElement(By.XPath("//header/div[2]/div[1]/div[1]/div[3]/div[1]/div[1]/a[1]/div[1]/div[1]"));
            // ac.MoveToElement(CartElement).Build().Perform();


            Actions action = new Actions(driver);
            //driver.FindElement(HoverOnCartBTN);
            action.MoveToElement(driver.FindElement(HoverOnCartBTN)).Perform();
            
            driver.FindElement(CheckoutBTN).Click();
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;

            js.ExecuteScript("window.scrollBy(0,400);");

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


            driver.FindElement(AddressTXT).SendKeys(address);
            driver.FindElement(CityTXT).SendKeys(city);
            driver.FindElement(DeliveryMethodDSD).Click();
            driver.FindElement(ConfirmBTN).Click();

            Thread.Sleep(15000);

            string message = driver.FindElement(Confirmation).Text;
            Assert.AreEqual("Your order has been placed!", message);

        }
    }
}
