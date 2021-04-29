using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAutomation.Action
{
    class Moveto
    {
        public static void MovetoElemeten(IWebDriver driver, By csSelector)
        {

            IWebElement Selector = driver.FindElement(csSelector);
            Actions actions = new Actions(driver);
            actions.MoveToElement(Selector).Build().Perform();

        }
    }
}
