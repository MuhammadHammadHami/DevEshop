using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace veritiv_POM
{
    class MakeAnEnquiry : BasePage
    {
        public void enquiry(string url, string number, string firstname, string lastname, string email, string enquiry )
        {
            By NewsLetterPOPup = By.CssSelector("popup - title");
            By NLpopupCancelPTN = By.XPath("//button[contains(text(),'×')]");
            By NavigateToEnquiryTXT = By.XPath("//strong[contains(text(),'Make An Enquiry')]");
            By MobileNoTXT = By.XPath("//input[@id='input-telephone']");
            By FirstNameTXT = By.XPath("//input[@id='input-firstname']");
            By LastNameTXT = By.XPath("//input[@id='input-lastname']");
            By EmailTXT = By.XPath("//input[@id='input-email']");


            By EnquiryTXT = By.XPath("//textarea[@id='input-enquiry']");
            By submitBTN = By.XPath("//body/div[@id='wrapper']/div[@id='customer-enquiry']/div[1]/div[1]/form[1]/div[1]/div[1]/input[1]");
            By Home = By.XPath("//header/div[3]/div[1]/div[1]/div[2]/div[1]/nav[1]/div[1]/div[2]/div[1]/div[1]/ul[1]/li[1]/a[1]/span[1]/strong[1]");


            /*            driver.Url = url;

                        Thread.Sleep(5000);

                        driver.FindElement(NewsLetterPOPup).Click();
                        driver.FindElement(NLpopupCancelPTN).Click();
                        Thread.Sleep(3000);*/

            driver.FindElement(NavigateToEnquiryTXT).Click();
            Thread.Sleep(5000);

            if(driver.FindElement(MobileNoTXT).GetAttribute("") == null)
            {
                driver.FindElement(MobileNoTXT).SendKeys(number);
                driver.FindElement(MobileNoTXT).SendKeys(Keys.Tab);
            }


            Boolean fnisEnabled = driver.FindElement(FirstNameTXT).Displayed;
            Boolean lnisEnabled = driver.FindElement(LastNameTXT).Displayed;
            Boolean emailisEnabled = driver.FindElement(EmailTXT).Displayed;

            if (fnisEnabled && lnisEnabled && emailisEnabled)
            {
                driver.FindElement(FirstNameTXT).SendKeys(firstname);
                driver.FindElement(LastNameTXT).SendKeys(lastname);
                driver.FindElement(EmailTXT).SendKeys(email);
            }

            driver.FindElement(EnquiryTXT).SendKeys(enquiry);
            Thread.Sleep(20000);
            driver.FindElement(submitBTN).Click();
            Thread.Sleep(5000);
            driver.FindElement(Home);
            Thread.Sleep(10000);



        }
    }
}
