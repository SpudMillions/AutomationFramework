using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace AutomationFramework
{
    public class LoginPage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("http://www.phptravels.net/login");
            WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            IWebElement myDynamicElement = wait.Until<IWebElement>(d => d.FindElement(By.Name("username"))); 

        }

        public static LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        }

        public class LoginCommand
        {
            private string userName;
            private string password;

            public LoginCommand(string userName)
            {
                this.userName = userName;
            }

            public LoginCommand WithPassword(string password)
            {
                this.password = password;
                return this;
            }

            public void Login()
            {
                var loginInput = Driver.Instance.FindElement(By.Name("username"));
                loginInput.SendKeys(userName);

                var passwordInput = Driver.Instance.FindElement(By.Name("password"));
                passwordInput.SendKeys(password);

                var loginButton = Driver.Instance.FindElement(By.XPath("//*[@id=\"loginfrm\"]/div[4]/button"));
                loginButton.Click();
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement myDynamicElement = wait.Until<IWebElement>(d => d.FindElement(By.XPath("/html/body/div[3]/div[1]/div/div[1]/h3")));
            }
        }
    }
}
