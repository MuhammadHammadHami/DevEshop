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
        AddToCart addtocart = new AddToCart();

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

            loginpage.login("https://dev.eshoppers.pk/", "muhammad.hammad@cooperativecomputing.com", "12345678");

        }

        [TestMethod]
        public void TestCase_Enquiry()
        {
            TestCase_Login();

            makeanenquiry.enquiry("03323498842", "This is Enquiry field from Selenium");
        }

/*        [TestMethod]
        public void TestCase_PlaceOrder()
        {
            TestCase_Login();

            addtocart.addToCart("03323498842", "address", "City");

        }*/

       /* [TestMethod]
        public void TestCase_Checkout()
        {

            loginpage.login("https://dev.eshoppers.pk/", "muhammad.hammad@cooperativecomputing.com", "12345678");

        }*/


    }
}