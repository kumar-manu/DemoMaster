using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProj.Pages
{
    class GmailHomePage
    {

        public GmailHomePage()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How=How.Id,Using = "Passwd")]
        public IWebElement textPassword { get; set; }

        [FindsBy(How=How.Name,Using = "signIn")]
        public IWebElement btnSignIn { get; set; }

        public void VerifyHomePage()
        { }

    }
}
