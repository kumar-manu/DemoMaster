using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//Manu
namespace SeleniumProj.Tests
{
    [TestClass]
    public class SampleTest
    {
       static string webAppName;

        //[ClassInitialize]
        //public static void TestClassinitialize(TestContext context)
        //{
        //    webAppName = context.Properties["webAppUserName"].ToString();

        //    //other settings etc..then use your test settings parameters here...
        //}

        private TestContext testContextInstance;
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestInitialize]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver(@"C:\Users\mkumar\Documents\Visual Studio 2015\Projects\LearnSelenium\SeleniumProj\bin\Debug");
            PropertiesCollection.driver.Navigate().GoToUrl(TestContext.Properties["webAppUrl"].ToString());

        }


        [TestMethod]
        public void LoginTest()
        {
            Pages.GmailLoginPage login = new Pages.GmailLoginPage();
            //login.Login(TestContext.Properties["webAppUserName"].ToString(),"123456")
            //    .VerifyHomePage();
                
           

        }


        [TestCleanup]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
        } 

    }
}
