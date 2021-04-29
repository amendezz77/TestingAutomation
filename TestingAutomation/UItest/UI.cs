using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAutomation.UItest
{
    class UI
    {
        private static By categorias = By.LinkText("Categorías");
        private static By tecnologia = By.LinkText("Tecnología");
        private static By televisores = By.LinkText("Televisores");
        private static By masRelevantes = By.ClassName("andes-dropdown__trigger");
        private static By menorPrecio = By.LinkText("Menor precio");
        private static By ultimoItem = By.LinkText("TV Dalton DA-LE32X3663 LED HD 32");
        private static By precio = By.CssSelector("div.ui-pdp-price__second-line span.price-tag.ui-pdp-price__part span.price-tag-fraction");

        private static By eduEmpleos = By.LinkText("Empleos");
        private static By seleccPuesto = By.CssSelector("a[id='cmbFiltroPuestos']");
        private static By puesto = By.LinkText("Testing QA");
        private static By testingqa = By.CssSelector("#formFiltros > div.filtrosMB > div.tagItem.tagItemBig > span");

        
        public static By GetTestingqa()
        {
            return testingqa;
        }

        public static void SetTestingqa(By a)
        {
          testingqa = a;

        }

        public static By GetPuesto()
        {
            return puesto;
        }



        public static By GetSeleccPuesto()
        {
            return seleccPuesto;
        }

        public static By GetEduEmpleos()
        {
            return eduEmpleos;
        }


        public static By GetCategorias()
        {
            return categorias;
        }

        public static By GetTecnologia()
        {
            return tecnologia;
        }


        public static By GetTelevisores()
        {
            return televisores;
        }

        public static By GetMasRelevantes()
        {
            return masRelevantes;
        }

        public static By GetMenorPrecio()
        {
            return menorPrecio;
        }

        public static By GetUltimoItem()
        {
            return ultimoItem;
        }

        public static By GetPrecio()
        {

            return precio;
        }
    }
}
