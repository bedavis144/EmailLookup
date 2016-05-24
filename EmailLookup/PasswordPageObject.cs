using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EmailLookup
{
    class PasswordPageObject
    {
        public PasswordPageObject()
        {
            PageFactory.InitElements(TestProperties.driver, this);
        }

        [FindsBy(How = How.Name, Using = "Passwd")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Id, Using = "signIn")]
        public IWebElement btnSignIn { get; set; }

        public void enterPswd(string password)
        {
            Console.WriteLine(txtPassword.Enabled);
            //btnSignIn.btnClick();
        }




    }
}
