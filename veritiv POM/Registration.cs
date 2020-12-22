using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace veritiv_POM
{
    class Registration : BasePage
    {
        public void registration(string url, string firstname, string lastname, string email, string number, string address, string city, string country, string password, string confirm_password )
        {

            By RegistrationLINK = By.XPath("//header/div[2]/div[1]/div[1]/div[3]/ul[1]/li[2]/a[2]");
            By FirstNameTXT = By.XPath("//input[@id='input-firstname']");
            By LastNameTXT = By.XPath("//input[@id='input-lastname']");
            By EmailTXT = By.XPath("//input[@id='input-email']");
            By MobileNoTXT = By.XPath("//input[@id='input-telephone']");
            By Address1TXT = By.XPath("//input[@id='input-address-1']");
            By CityTXT = By.XPath("//input[@id='input-city']");
            By CountryTXT = By.XPath("//input[@id='input-country']");
            By PasswordTXT = By.XPath("//input[@id='input-password']");
            By ConfirmPasswordTXT = By.XPath("//input[@id='input-confirm']");
            By PrivacyPolicyCB = By.XPath("//body/div[@id='wrapper']/div[@id='account-register']/div[1]/div[1]/form[1]/div[1]/div[1]/input[1]");
            By ContinueBTN = By.XPath("//body/div[@id='wrapper']/div[@id='account-register']/div[1]/div[1]/form[1]/div[1]/div[1]/input[2]");
            By ConfirmationMessage = By.XPath("//h1[contains(text(),'Your Account Has Been Created!')]");
            
            By Home = By.XPath("//header/div[3]/div[1]/div[1]/div[2]/div[1]/nav[1]/div[1]/div[2]/div[1]/div[1]/ul[1]/li[1]/a[1]/span[1]/strong[1]");


            driver.Url = url;

            Thread.Sleep(3000);
            driver.FindElement(By.ClassName("popup-title")).Click();
            driver.FindElement(By.XPath("//button[contains(text(),'×')]")).Click();
            Thread.Sleep(3000);

            driver.FindElement(RegistrationLINK).Click();
            Thread.Sleep(5000);
            driver.FindElement(FirstNameTXT).SendKeys(firstname);
            driver.FindElement(LastNameTXT).SendKeys(lastname);

            IJavaScriptExecutor js = driver as IJavaScriptExecutor;

            js.ExecuteScript("window.scrollBy(0,200);");

            driver.FindElement(EmailTXT).SendKeys(email);
            driver.FindElement(MobileNoTXT).SendKeys(number);

            js.ExecuteScript("window.scrollBy(0,200);");

            driver.FindElement(Address1TXT).SendKeys(address);
            driver.FindElement(CityTXT).SendKeys(city);
            
            js.ExecuteScript("window.scrollBy(0,200);");

            //driver.FindElement(CountryTXT).SendKeys(country);

            driver.FindElement(PasswordTXT).Clear();
            driver.FindElement(PasswordTXT).SendKeys(password);

            js.ExecuteScript("window.scrollBy(0,200);");

            driver.FindElement(ConfirmPasswordTXT).Clear();
            driver.FindElement(ConfirmPasswordTXT).SendKeys(confirm_password);
            driver.FindElement(PrivacyPolicyCB).Click();

            Thread.Sleep(15000);

            driver.FindElement(ContinueBTN).Click();
            Thread.Sleep(5000);

            string message = driver.FindElement(ConfirmationMessage).Text;
            Thread.Sleep(3000);
            Assert.AreEqual("Your Account Has Been Created!", message, "Registration Failed!");


            driver.FindElement(Home).Click();


            Thread.Sleep(5000);



        }

    }
}
