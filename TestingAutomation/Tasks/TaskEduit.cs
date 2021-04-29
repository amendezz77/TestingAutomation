
namespace TestingAutomation.Tasks
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using OpenQA.Selenium;
    using System;
    using System.Threading;
    using TestingAutomation.Action;
    using TestingAutomation.UItest;
    class TaskEduit
    {
        public static void ClickPestaEmpledo(IWebDriver driver, string a)
        {
            Click.On(driver, UI.GetEduEmpleos());
            Thread.Sleep(Literales.TimemMed);
            Click.ScreenCap(driver);
            Thread.Sleep(Literales.TimemMed);
            Click.On(driver, UI.GetSeleccPuesto());
            Thread.Sleep(Literales.TimemMed);
            Moveto.MovetoElemeten(driver, UI.GetPuesto());
            Thread.Sleep(Literales.TimemMed);
            Click.On(driver, UI.GetPuesto());
            Thread.Sleep(Literales.TimemMed);
            String b = driver.FindElement(UI.GetTestingqa()).Text;
             Assert.AreEqual(a, b);
        }
    }

}
