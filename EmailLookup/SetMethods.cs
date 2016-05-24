using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace EmailLookup
{
    public static class SetMethods
    {
        // Extended method for entering text
        public static void EnterText(this IWebElement element, string value)
        {
            //Clears text and writes new value
            element.Clear();
            if (value != "")
                element.SendKeys(value);
        }

        public static void btnClick(this IWebElement element)
        {
            element.Submit();
        }

    }
}
