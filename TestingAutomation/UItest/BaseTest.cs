using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAutomation.UItest
{
    class BaseTest
    {
        private IWebDriver driver;
        private string url;

        /// <summary>
        /// Gets or sets url.
        /// </summary>
        public string Url { get => this.url; set => this.url = value; }

        /// <summary>
        /// Gets or sets driver.
        /// </summary>
        protected IWebDriver Driver { get => this.driver; set => this.driver = value; }


        [SetUp]
        public void SetUpBase()
        {

            this.Driver = new ChromeDriver();
            this.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(400);
            this.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(200);
            this.Driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDownBase()
        {
            var currentContext = TestContext.CurrentContext;
            var testName = currentContext.Test.Name;

            Console.WriteLine("Test Cleanup");
            Console.WriteLine("Test name: " + testName);
        }
    }
}
