using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.ComponentModel.DataAnnotations;
/*[assembly: Parallelize(Workers = 5, Scope = ExecutionScope.MethodLevel)]*/

namespace veritiv_POM
{
    [TestClass]
    public class ExecutionClass
    {
        
        BasePage basepage = new BasePage();
        LoginPage loginpage = new LoginPage();
        MakeAnEnquiry makeanenquiry = new MakeAnEnquiry();
        MakeAnOffer makeanoffer = new MakeAnOffer();
        AddToCart addtocart = new AddToCart();
        Registration register = new Registration();
        Checkout checkout = new Checkout();

        #region Execution Hierarchy

        [TestInitialize()]
        public void Initialize()
        {
            basepage.SeleniumInit();
        }

        [TestCleanup()]
        public void Cleanup()
        {
            BasePage.driver.Close();
            BasePage.driver.Quit();
            BasePage.driver.Dispose();
        }

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {

        }

        [ClassCleanup()]
        public static void ClassCleanup()
        {

        }

        [AssemblyInitialize()]
        public static void AssemblyInit(TestContext context)
        {

        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {

        }

        #endregion

        [TestMethod]
        public void TestCase_Login()
        {

            loginpage.login("https://dev.eshoppers.pk/", "03323498842", "12345678");

        }

        [TestMethod]
        public void TestCase_Enquiry()
        {

            TestCase_Login();
            makeanenquiry.enquiry("https://dev.eshoppers.pk/", "213323232341", "First Name","Last Name","muhammad.hammad@cooperativecomputing.com", "This is Enquiry field from Selenium");
        }


        [TestMethod]
        public void TestCase_Offer()
        {
           makeanoffer.offer("https://dev.eshoppers.pk/", "213323232041", "First Name", "Last Name", "muhammad.hammad@cooperativecomputing.com", "19");
        }


        [TestMethod]
        public void TestCase_Registration()
        {
            register.registration("https://dev.eshoppers.pk/", "Selenium", "User", "muhammad.hammad@cooperativecomputing.com", "12343214213", "Selenium Address", "Selenium City", "Selenium Country", "12345678", "12345678");


        }

        [TestMethod]
        public void TestCase_AddToCart()
        {
            addtocart.addToCart("https://dev.eshoppers.pk/");

        }

         [TestMethod]
         public void TestCase_Checkout()
         {
            TestCase_AddToCart();
             checkout.CheckOut("12123202342", "Selenium","User", "muhammad.hammad@cooperativecomputing.com", "Selenium Address", "Selenium City");

         }
    }
}