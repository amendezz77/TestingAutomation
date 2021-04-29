using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingAutomation.Action;
using TestingAutomation.UItest;

namespace TestingAutomation.Tasks
{
    class TaskML
    {
        public static void SelectBenef(IWebDriver driver)
        {
            Moveto.MovetoElemeten(driver, UI.GetCategorias());
            Moveto.MovetoElemeten(driver, UI.GetTecnologia());
            Click.On(driver, UI.GetTelevisores());
        }


        public static void MenorPrecion(IWebDriver driver)
        {
            Click.On(driver, UI.GetMasRelevantes());

            Click.On(driver, UI.GetMenorPrecio());


        }

        public static void UltimoItem(IWebDriver driver)
        {
            Click.On(driver, UI.GetUltimoItem());
        }

        public static void ValidacionPrecio(IWebDriver driver, string a)
        {
            //Assert.AssertAreEqual(a, UI.GetPrecio());
        }
    }
}
