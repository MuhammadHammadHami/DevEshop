using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace veritiv_POM
{
    class MakeAnEnquiry : BasePage
    {
        public void enquiry(string number, string enquiry )
        {
            By NavigateToEnquiryTXT = By.XPath("//strong[contains(text(),'Make An Enquiry')]");
            By MobileNoTXT = By.XPath("//input[@id='input-telephone']");
            By EnquiryTXT = By.XPath("//textarea[@id='input-enquiry']");
            By submitBTN = By.XPath("//body/div[@id='wrapper']/div[@id='customer-enquiry']/div[1]/div[1]/form[1]/div[1]/div[1]/input[1]");


            driver.FindElement(NavigateToEnquiryTXT).Click();
            driver.FindElement(MobileNoTXT).SendKeys(number);
            driver.FindElement(EnquiryTXT).SendKeys(enquiry);
            driver.FindElement(submitBTN).Click();

            Thread.Sleep(30000);
            
        }
    }
}
