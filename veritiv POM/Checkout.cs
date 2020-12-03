using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace veritiv_POM
{
    class Checkout : BasePage
    {
        public void CheckOut(string MobileNo, string address, string city)
        {
            By CheckoutBTN = By.XPath("//a[contains(text(),'Checkout')]");
            By MobileNoTXT = By.XPath("//input[@id='input-payment-telephone']");
            By AddressTXT = By.XPath("///input[@id='input-payment-address-1']");
            By CityTXT = By.XPath("//input[@id='input-payment-city']");
            By TermsAndConditionCB = By.XPath("//body/div[@id='wrapper']/div[@id='checkout-checkout']/div[1]/div[1]/div[1]/div[7]/div[1]/div[1]/fieldset[1]/div[1]/div[1]/div[1]/div[1]/input[1]");

            By ConfirmBTN = By.XPath("//input[@id='confirm']");

            Actions ac = new Actions(driver);
         // IWebElement CartElement = driver.FindElement(By.XPath("//header/div[2]/div[1]/div[1]/div[3]/div[1]/div[1]/a[1]/div[1]/div[1]"));
           // ac.MoveToElement(CartElement).Build().Perform();


            driver.FindElement(CheckoutBTN).Click();
            driver.FindElement(MobileNoTXT).SendKeys(MobileNo);
            driver.FindElement(AddressTXT).SendKeys(address);
            driver.FindElement(CityTXT).SendKeys(city);
            driver.FindElement(TermsAndConditionCB).Click();

            driver.FindElement(ConfirmBTN).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
        }
    }
}
