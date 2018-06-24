using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace JosephusProblem
{
    [TestClass()]
    public class PruebaJosephus
    {
        private int elResultadoEsperado;
        private int elresultadoObtenido;
        [TestMethod()]
        public void GeneraNumeroDesobrevivientes()
        {
            elResultadoEsperado = 1201;
            elresultadoObtenido = GeneraNumeroDeSobrevivientes.GeneraElNumeroDeSobrevivientes(1624);
            Assert.AreEqual(elResultadoEsperado,elresultadoObtenido);
        }
    }
}
