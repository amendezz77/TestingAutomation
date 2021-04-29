namespace TestingAutomation.Test
{
    using NUnit.Framework;
    using TestingAutomation.Tasks;
    using TestingAutomation.UItest;

    class TestML : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            this.Driver.Url = "https://www.mercadolibre.com.ar/";
        }
        [Test]
        public void TestMercado()
        {
            TaskML.SelectBenef(this.Driver);

            TaskML.MenorPrecion(this.Driver);

            TaskML.UltimoItem(this.Driver);

            //TaskML.ValidacionPrecio(this.Driver, "22.999");
            //En Construcion :(
        }
    }
}
