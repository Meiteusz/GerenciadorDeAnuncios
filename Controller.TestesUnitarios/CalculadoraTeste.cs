using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Controller.TestesUnitarios
{
    [TestClass]
    public class CalculadoraTeste
    {
        [TestMethod]
        public void CalcularAlcanceAnuncio_QuandoCalcular_Retorna30VisualizacoesTotais()
        {
            Calculadora calculadora = new Calculadora();
            int ValorInvestido = 1;
            calculadora.CalcularAlcanceAnuncio(ValorInvestido);

            int ResultadorEsperado = 30;

            Assert.AreEqual(ResultadorEsperado, calculadora.TotalVisualizacoes);
        }
    }
}
