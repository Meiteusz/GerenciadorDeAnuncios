using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Controller.TestesUnitarios
{
    [TestClass]
    public class AnuncioTeste
    {
        AnuncioBLL anuncioBLL = new AnuncioBLL();

        [TestMethod]
        public void CadastrarAnuncio_QuandoInseridoNoBanco_RetornaTrue()
        {
            Anuncio anuncio = new Anuncio();
            anuncio.Nome = "Anuncio para Teste Unitário";
            anuncio.Cliente = "Teste Unitário";
            anuncio.DataInicio = Convert.ToDateTime("2021 - 07 - 12");
            anuncio.DataTermino = Convert.ToDateTime("2021 - 08 - 17");
            anuncio.InvestimentoDia = 10;

            bool ResultadoRetornado = anuncioBLL.CadastrarAnuncio(anuncio);

            Assert.IsTrue(ResultadoRetornado);
        }

        [TestMethod]
        public void ValidarAnuncio_QuandoValidado_RetornaStringVazia()
        {
            Anuncio anuncio = new Anuncio();
            anuncio.Nome = "Anuncio para Teste Unitário";
            anuncio.Cliente = "Teste Unitário";
            anuncio.DataInicio = Convert.ToDateTime("2021 - 07 - 12");
            anuncio.DataTermino = Convert.ToDateTime("2021 - 08 - 17");
            anuncio.InvestimentoDia = 10;

            string ResultadoRetornado = anuncioBLL.ValidarAnuncio(anuncio);

            Assert.AreEqual(string.Empty, ResultadoRetornado);
        }
    }
}
