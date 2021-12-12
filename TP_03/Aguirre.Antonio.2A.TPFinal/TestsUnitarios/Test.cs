using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Entidades;

namespace TestsUnitarios
{
    [TestClass]
    public class Test
    {

        Dispositivo c1 = new Computadora(1, "Antonio", "Rota", 5000, DateTime.Parse("13/7/2022"));
        Dispositivo c2 = new Computadora(1, "Antonio", "Rota", 5000, DateTime.Parse("13/7/2022"));
        Dispositivo c3 = new Computadora(2, "Ariel", "Rota", 7000, DateTime.Parse("17/7/2022"));

        Listado<Dispositivo> listado = new Listado<Dispositivo>();

        [TestMethod]
        public void TestOperadorIgualIgualDispositivo_True()
        {
            Assert.IsTrue(c1 == c2);

            Assert.IsFalse(c1 == c3);
        }

        [TestMethod]
        public void TestOperadorIgualIgualListado_True()
        {
            listado.Lista.Add(c1);

            Assert.IsFalse(listado + c2);

            Assert.IsTrue(listado == c2);
        }
    }
}
