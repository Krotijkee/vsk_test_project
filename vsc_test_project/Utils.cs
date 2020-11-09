using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace vsc_test_project
{
    public class Utils
    {
        public static IWebDriver goToUrl()
        {
            return new OpenQA.Selenium.Chrome.ChromeDriver("drivers");
            
        }
    }
}
