using NUnit.Framework;
using Biblioteca;

namespace TestCalculos
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestCalcularMaximoOK()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int maximo = Calculos.maximo(a);
            Assert.AreEqual(9, maximo);
        }

        [Test]
        public void TestCalcularMaximoeERROR()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int maximo = Calculos.maximo(a);
            Assert.AreNotEqual(8, maximo);
        }

        [Test]
        public void TestCalcularMinimoOK()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int minimo = Calculos.minimo(a);
            Assert.AreEqual(1, minimo);
        }

        [Test]
        public void TestCalcularPromedioOK()
        {
            int[] a = new int[] { 2, 2, 2, 2, 2, 2, 2, 2, 2 };
            double promedio = Calculos.promedio(a);
            Assert.AreEqual(2, promedio);
        }
    }
}