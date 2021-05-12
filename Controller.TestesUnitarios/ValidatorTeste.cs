using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Controller.TestesUnitarios
{
    [TestClass]
    public class ValidatorTeste
    {
        Validator validator = new Validator();

        [TestMethod]
        public void ValidarNome_QuandoReceberNome_RetornaStringVazia()
        {
            string Nome = "Nome do Anuncio";

            string ResultadoRetornado = validator.ValidarNome(Nome);

            Assert.AreEqual(string.Empty, ResultadoRetornado);
        }

        [TestMethod]
        public void ValidarNomeCliente_QuandoReceberNomeCliente_RetornaStringVazia()
        {
            string NomeCliente = "Ronaldo Pereira";

            string ResultadoRetornado = validator.ValidarNomeCliente(NomeCliente);

            Assert.AreEqual(string.Empty, ResultadoRetornado);
        }

        [TestMethod]
        public void ValidarInvestimentoDia_QuandoReceberInvestimentoDia_RetornaStringVazia()
        {
            float InvestimentoDia = 1;

            string ResultadoRetornado = validator.ValidarInvestimentoDia(InvestimentoDia);

            Assert.AreEqual(string.Empty, ResultadoRetornado);
        }

        [TestMethod]
        public void ValidarDatas_QuandoReceberData_RetornaStringVazia()
        {
            DateTime dataEntrada = Convert.ToDateTime("2021 / 07 / 12");
            DateTime dataSaida = Convert.ToDateTime("2021 / 08 / 17");

            string ResultadoRetornado = validator.ValidarDatas(dataEntrada, dataSaida);

            Assert.AreEqual(string.Empty, ResultadoRetornado);
        }
    }
}
