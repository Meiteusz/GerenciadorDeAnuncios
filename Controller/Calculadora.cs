namespace Controller
{
    public class Calculadora
    {
        /*  
            Documentação do script:
          * Este script calcula o as visualizações do anúncio original, e também a quantidade máxima de visualizações (visualizações originais e as visualizações dos compartilhamentos)
          * O script recebe um valor investido no formato int, isso porque o anúncio recebe 30 visualizações a cada R$ 1,00 investido então os centavos neste caso não tem muita relevância
          * O número de cliques é calculado através da quantidade de visualizações, 12% do valor de visualizações originais
          * O número de compartilhamentos é calculado através da quantidade de cliques, 3% a cada 20 cliques
          * 
          * Primeiro é calculado as quantidades de visualizações, cliques e compartilhamentos feitas através do anúncio original, após isso é possível ter o calculo
          * da quantidade de visualizações e cliques feitos através dos compartilhamentos (É compartilhado no máximo 4 vezes em sequência)
        */

        // Teste unitário deste script está no projeto Controller.TestesUnitarios.CalculadoraTeste

        public int VisualizacoesGerais { get; private set; }
        public int TotalVisualizacoes { get; private set; }

        public int CliquesGerais { get; private set; }
        public int TotalCliques { get; private set; }

        public int Compartilhamentos { get; private set; }
        public int TotalCompartilhamentos { get; private set; }

        public void CalcularAlcanceAnuncio(int ValorInvestido)
        {
            TotalVisualizacoes = ValorInvestido * 30;                  //
            TotalCliques = (TotalVisualizacoes * 12) / 100;            // Valores do anúncio original
            Compartilhamentos = (TotalCliques * 3) / 20;               //                                                       // 1ª pessoa
            TotalCompartilhamentos = Compartilhamentos;


            for (int sequenciaCompartilhamento = 0; sequenciaCompartilhamento < 3; sequenciaCompartilhamento++)                 // 2ª,3ª,4ª pessoa
            {
                if (Compartilhamentos < 1)
                {
                    break;
                }
                else
                {
                    VisualizacoesGerais = Compartilhamentos * 40;
                    CliquesGerais = (VisualizacoesGerais * 12) / 100;
                    Compartilhamentos = (CliquesGerais * 3) / 20;

                    TotalVisualizacoes += VisualizacoesGerais;
                    TotalCliques += CliquesGerais;
                    TotalCompartilhamentos += Compartilhamentos;
                }
            }
        }
    }
}
