using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationFramework
{
    public class DashboardPage
    {
        public static bool IsAt
        {
            get
            {
                var pagetitle = Driver.Instance.Title;
                if(pagetitle == "My Account")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
    }
}
