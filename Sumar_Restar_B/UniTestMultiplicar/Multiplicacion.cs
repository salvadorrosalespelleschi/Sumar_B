using Microsoft.AspNetCore.Http.Connections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumarB.Controllers;

namespace UniTestMultiplicar
{
    [TestClass]
    public class Multiplicacion
    {
        [TestMethod]
        public void MultiplyTest1()
        {
            //arrange
            SumaController multiplicarController = new SumaController();
            float a = 2;
            float b = 3;
            float expected = 6;
            //act
            float resultado = multiplicarController.Mul(a, b);
            //assert
            Assert.AreEqual(expected, resultado);

        }
    }
}
