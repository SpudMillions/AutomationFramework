using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationFramework;

namespace AutomationTests
{
    [TestClass]
    class HotelTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void Can_Search_For_Hotels()
        {
            LoginPage.GoTo();
            LoginPage.LoginAs("testertesty1@yahoo.com").WithPassword("password");

            HotelsPage.GoTo();
            HotelsPage.QuickSearchForLocation("TraverseCity")
                .WithCheckInDate()
                .WithCheckOutDate()
                .WithAdults()
                .WithChildren()
                .Search();

            Assert.AreEqual(HotelsPage.Location = "Traverse City, Michigan, United States", "Location did not match search");

        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }

    }
}
