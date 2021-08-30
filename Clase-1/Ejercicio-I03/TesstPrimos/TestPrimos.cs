using NUnit.Framework;
using Biblioteca;
using System.Collections.Generic;

namespace TesstPrimos
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestPrimosOK()
        {
            List<int> esperado = new List<int> { 2, 3, 5};
            List<int> numerosPrimos = Primos.numerosPrimos(7);
            Assert.AreEqual(esperado, numerosPrimos);
        }
    }
}