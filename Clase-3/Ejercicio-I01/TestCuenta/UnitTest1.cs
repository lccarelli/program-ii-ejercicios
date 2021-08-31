using NUnit.Framework;
using Biblioteca;

namespace TestCuenta
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CuentaCrear()
        {
            Cuenta cuenta = new Cuenta("Leia", 666);
            Assert.AreEqual("Leia", cuenta.getTitular());
            Assert.AreEqual(66, cuenta.getCantidad());
        }
    }
}