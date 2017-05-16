using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using OpenQA.Selenium.Chrome;

namespace AutomationFramework
{
    public class Driver
    {
        public static IWebDriver Instance { get; internal set; }
        
        //set driver to use
        public static void Initialize()
        {
            Instance = new FirefoxDriver();
            //Instance = new ChromeDriver();
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public static void Close()
        {
            Instance.Close();
        }
    }
}