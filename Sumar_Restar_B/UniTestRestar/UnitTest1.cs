using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumarB.Controllers;

namespace UniTestRestar
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SubTest1()
        {
            //arrange
            SumaController restaController = new SumaController();
            float a = 2;
            float b = 3;
            float expected = -1;
            //act
            float resultado = restaController.Sub(a, b);
            //assert
            Assert.AreEqual(expected, resultado);
        }
    }
}
