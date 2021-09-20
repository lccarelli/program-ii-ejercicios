using NUnit.Framework;
using System.Collections.Generic;
using Veterinaria;

namespace TestVeterinaria
{
    public class Tests
    {
        private string domicilio = "Vulcano";
        private string nombre = "Spock";
        private string apellido = "de Shikahr";
        private long telefono = 666777888;
        private Mascota MascotaSinVacuna = new Mascota("Perro", "Luke", new System.DateTime());
        List<Mascota> listaMascotas = new List<Mascota>();
     
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestClientePerroSinVacuna()
        {
            Cliente cliente = new Cliente(domicilio, nombre, apellido, telefono, MascotaSinVacuna);
            listaMascotas.Add(MascotaSinVacuna);
            Assert.AreEqual("Vulcano", cliente.Domicilio);
            Assert.AreEqual("Spock", cliente.Nombre);
            Assert.AreEqual("de Shikahr", cliente.Apellido);
            Assert.AreEqual("666777888", cliente.Telefono);
            Assert.AreEqual(listaMascotas, cliente.GetMascotas());
        }
    }
}