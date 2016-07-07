using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using L

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        private TestContext m_testContext;

        public TestContext TestContext
        {

            get { return m_testContext; }

            set { m_testContext = value; }

        }



        [TestInitialize]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("http:\\mail.google.com");

        }


        [TestMethod]
        public void LoginTest()
        {
            Pages.GmailLoginPage login = new Pages.GmailLoginPage();
            login.Login("manustar47", "123456")
                .VerifyHomePage();



        }


        [TestCleanup]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
        }
    }
}
