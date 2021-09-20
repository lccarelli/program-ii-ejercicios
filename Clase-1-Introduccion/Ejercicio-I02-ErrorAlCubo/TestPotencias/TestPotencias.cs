using NUnit.Framework;
using Biblioteca;

namespace TestPotencias
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestPotenciaIterando()
        {
            int potencia = ErrorAlCubo.PotenciaIterando(6, 2);
            Assert.AreEqual(36, potencia);
        }

        [Test]
        public void TestPotenciaRecursividadConCero()
        {
            double potencia = ErrorAlCubo.PotenciaConRecursividad(6, 0);
            Assert.AreEqual(1, potencia);
        }

        [Test]
        public void TestPotenciaRecursividadExponenteMenorACero()
        {
            double potencia = ErrorAlCubo.PotenciaConRecursividad(6, -2);
            Assert.AreEqual(0.027777777777777776d, potencia);
        }

        [Test]
        public void TestPotenciaRecursividadExponeneteMayorAcero()
        {
            double potencia = ErrorAlCubo.PotenciaConRecursividad(6, 2);
            Assert.AreEqual(36, potencia);
        }

        [Test]
        public void TestPotenciaIterandoAlCubo()
        {
            double potencia = ErrorAlCubo.PotenciaConRecursividad(6, 3);
            Assert.AreEqual(216, potencia);
        }
    }
}