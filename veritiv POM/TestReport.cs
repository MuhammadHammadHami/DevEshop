using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace veritiv_POM
{
    class TestReport
    {
        public static ExtentReports extent;
        public static ExtentTest exParentTest;
        public static ExtentTest exChaildTest;
        public static string dirpath;


        public static void reportLogger(string testcasename)
        {
            extent = new ExtentReports();
            var dir = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin//Debug", "");

            Directory.CreateDirectory(dir + "\\Test_Execution_Report\\");
            Random rand = new Random();
            string randoomo = rand.Next(100).ToString();
            dirpath = dir + "\\Test_Execution_Report\\Test_Execution_Report\\" + "_" + testcasename;


            AventStack.ExtentReports.Reporter.ExtentHtmlReporter htmlReporter = new AventStack.ExtentReports.Reporter.ExtentHtmlReporter(dirpath);
            htmlReporter.Config.Theme = Theme.Dark;


            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("Host Name ", System.Net.Dns.GetHostName());
           // extent.AddSystemInfo("User Name ", System.Security.Principal.WindowsIdentity);



        }
    }
}
