using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AcumularPrecioTotal_Ok()
        {
            Lapiz lapiz = new Lapiz(1, "test", 200, Lapiz.eColor.Verde, 2);
            Lapiz lapiz2 = new Lapiz(2, "test2", 200, Lapiz.eColor.Verde, 2);
            List<Utiles> list = new List<Utiles>();
            list.Add(lapiz);
            list.Add(lapiz2);
            Cartuchera<Utiles> cartucheraTest = new Cartuchera<Utiles>(2, list, 10);


            int precioTotal = (int)cartucheraTest.PrecioTotal;
            int precioEsperado = (int)((int)lapiz.Precio + lapiz2.Precio);


            Assert.IsTrue(precioEsperado == precioTotal);
        }

        [TestMethod]
        public void Test_CrearArchivo_Ok() 
        {
            bool archivoCreado = GestorDeArchivos.CrearArchivo("test.txt","Esto es un test", false);

            Assert.IsTrue(archivoCreado);
        }

     
    }
}
