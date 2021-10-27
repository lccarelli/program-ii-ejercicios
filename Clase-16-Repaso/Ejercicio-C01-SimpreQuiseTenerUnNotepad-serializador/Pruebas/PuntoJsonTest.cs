using Microsoft.VisualStudio.TestTools.UnitTesting;
using IO;

namespace Pruebas
{
    [TestClass]
    public class PuntoJsonTest
    {
        [TestMethod]
        public void ValidarExtension_HappyPath()
        {
            //Arrange
            PuntoJson<string> puntoJson = new PuntoJson<string>();

            //Act
            bool retorno = puntoJson.ValidarExtension("archivo.json");

            //Assert
            Assert.IsTrue(retorno);
        }
    }
}
