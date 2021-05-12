using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace Model.TestesUnitarios
{
    [TestClass]
    public class ConexaoTeste
    {
        [TestMethod]
        public void Conectar_QuandoConectar_RetornaConexaoAberta()
        {
            Conexao conexao = new Conexao();

            ConnectionState ResultadoRetornado = conexao.Conectar().State;

            Assert.AreEqual(ConnectionState.Open, ResultadoRetornado);
        }
    }
}
