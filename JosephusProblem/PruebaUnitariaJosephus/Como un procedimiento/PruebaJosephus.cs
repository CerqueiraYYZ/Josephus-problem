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
            elResultadoEsperado = 23;
            elresultadoObtenido = GeneraNumeroDeSobrevivientes.GeneraElNumeroDeSobrevivientes(1);
            Assert.AreEqual(elResultadoEsperado,elresultadoObtenido);
        }
    }
}
