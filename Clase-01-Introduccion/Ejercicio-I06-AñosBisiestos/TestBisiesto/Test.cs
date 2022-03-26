using NUnit.Framework;
using Biblioteca;

namespace TestBisiesto
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void TestBisiestoOK()
        {
            int year = 2016;

            bool actual = Bisiesto.IsBisiesto(year);

            Assert.IsTrue(actual);
        }

        [Test]
        public void TestBisiestoNoOK()
        {
            int year = 2015;

            bool actual = Bisiesto.IsBisiesto(year);

            Assert.IsFalse(actual);
        }
    }
}