using Microsoft.AspNetCore.Http.Connections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumarB.Controllers;
using System.ComponentModel;

namespace UniTestSumar
{
    [TestClass]
    public class Suma
    {
        [TestMethod]
        public void AddTest1()
        {
            //arrange
            SumaController sumaController = new SumaController();
            float a = 2;
            float b = 3;
            float expected = 5;
            //act
            float resultado = sumaController.Add(a, b);
            //assert
            Assert.AreEqual(expected, resultado);
        }
    }
}
