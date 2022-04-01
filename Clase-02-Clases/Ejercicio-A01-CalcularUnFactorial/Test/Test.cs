using NUnit.Framework;
using Biblioteca;
using Moq;
using ServiceStack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Assert = NUnit.Framework.Assert;

namespace Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void TestFactorialOK()
        {
            int numero = 2;
            int expect = 2;

            int actual = CalcularUnFactorial.Calcular(numero);

            Assert.AreEqual(expect, actual);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException), "No se puede calcular un factorial a CERO")]
        public void TestFactorialError()
        {
            var numero = 0;

            CalcularUnFactorial.Calcular(numero);



        }
    }
}