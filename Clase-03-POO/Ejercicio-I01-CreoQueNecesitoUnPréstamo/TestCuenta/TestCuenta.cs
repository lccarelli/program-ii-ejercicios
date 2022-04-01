using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;

namespace TestCuenta
{
    [TestClass]
    public class TestCuenta
    {
        [TestMethod]
        public void TestIngresar()
        {
            Cuenta cuenta = new Cuenta("Laura", 100);

            cuenta.Ingresar(200);

            Assert.AreEqual(cuenta.Cantidad, 300);
        }

        [TestMethod]
        public void TestIngresarNegativo()
        {
            Cuenta cuenta = new Cuenta("Laura", 100);

            cuenta.Ingresar(-100);

            Assert.AreEqual(cuenta.Cantidad, 100);
        }

        [TestMethod]
        public void TestRetirar() 
        {
            Cuenta cuenta = new Cuenta("Laura", 100);

            cuenta.Retirar(50);

            Assert.AreEqual(cuenta.Cantidad, 50);
        }

        [TestMethod]
        public void TestRetirarMayor()
        {
            Cuenta cuenta = new Cuenta("Laura", 100);

            cuenta.Retirar(200);

            Assert.AreEqual(cuenta.Cantidad, 100);
        }
    }
}