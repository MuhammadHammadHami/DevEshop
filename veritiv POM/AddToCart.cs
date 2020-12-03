using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace veritiv_POM
{
    class AddToCart : BasePage
    {
        public void addToCart()
        {
            By NavigateToProduct = By.XPath("//body/div[@id='wrapper']/div[@id='content']/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[7]/div[1]/div[2]/div[1]/div[1]/div[1]/a[1]/img[1]");
            By addBTN = By.XPath("//input[@id='button-cart']");
 //         By CartElement = By.XPath("//header/div[2]/div[1]/div[1]/div[3]/div[1]/div[1]/a[1]/div[1]/div[1]");

            Thread.Sleep(1000);

            driver.FindElement(NavigateToProduct).Click();
            driver.FindElement(addBTN);


        }
    }
}
