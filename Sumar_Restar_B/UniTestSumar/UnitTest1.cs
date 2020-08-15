using Microsoft.AspNetCore.Http.Connections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumarB.Controllers;
using System.ComponentModel;

namespace UniTestSumar
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTest1()
        {
            //arrange
            SumaController sumaController = new SumaController();
            int a = 2;
            int b = 3;
            int expected = 5;
            //act
            int resultado = sumaController.Add(a, b);
            //assert
            Assert.AreEqual(expected, resultado);
        }
    }
}
