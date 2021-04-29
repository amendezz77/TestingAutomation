namespace TestingAutomation.Test
{
    using NUnit.Framework;
    using System.Threading;
    using TestingAutomation.Tasks;
    using TestingAutomation.UItest;

    [TestFixture]
    class TestEducacionIT : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            
            this.Driver.Url = "https://www.educacionit.com/index";
            Thread.Sleep(Literales.TimemMed);
        }

        [Test]
        public void TestEmpleos()
        {
            TaskEduit.ClickPestaEmpledo(this.Driver, "Testing QA");
        }
    }
}
