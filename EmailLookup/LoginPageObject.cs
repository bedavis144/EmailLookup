using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EmailLookup
{
    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(TestProperties.driver, this);
        }

        [FindsBy(How = How.Id, Using = "Email")]
        public IWebElement txtUserName { get; set; }

        //[FindsBy(How = How.Id, Using = "Passwd-hidden")]
        //public IWebElement txtPasswd { get; set; }


        [FindsBy(How = How.Id, Using = "next")]
        public IWebElement btnNext { get; set; }

        //[FindsBy(How = How.Id, Using = "signIn")]
        //public IWebElement btnSignIn { get; set; }


        public GoogleSheetPageObject Login(string email, string password)
        {
            txtUserName.EnterText(email);
            btnNext.btnClick();
            
            PasswordPageObject pswdPage = new PasswordPageObject();
            pswdPage.enterPswd(password);

            return new GoogleSheetPageObject();
        }

    }



}
