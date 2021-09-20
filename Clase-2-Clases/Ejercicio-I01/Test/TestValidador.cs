using NUnit.Framework;
using Biblioteca;

namespace Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            bool result = Validador.validar(10, -100, 100);
            Assert.IsTrue(result);
        }
    }
}