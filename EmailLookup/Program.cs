using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace EmailLookup
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        [SetUp]
        public void Initialize()
        {
            //Create the reference for our browser
            TestProperties.driver = new ChromeDriver();

            //Navigate to Parking Calculator Web Page
            TestProperties.driver.Navigate().GoToUrl("https://docs.google.com/spreadsheets/d/1DXIUyXE1Q7MAnQpqtY0dREqaTN0o0UTiJFGMRRU-6w8/edit#gid=0");

            //Write to output
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void Test()
        {
            LoginPageObject loginPage = new LoginPageObject();

            loginPage.Login("brandon.davis017@gmail.com", "aventine");
        }
        
        [TearDown]
        public void CleanUp()
        {
            Console.WriteLine("Done");
        }
    }
}
