using Microsoft.AspNetCore.Http.Connections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumarB.Controllers;

namespace UniTestMultiplicar
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MultiplyTest1()
        {
            //arrange
            SumaController multiplicarController = new SumaController();
            int a = 2;
            int b = 3;
            int expected = 6;
            //act
            int resultado = multiplicarController.Mul(a, b);
            //assert
            Assert.AreEqual(expected, resultado);

        }
    }
}
