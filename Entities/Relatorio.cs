namespace Entities
{
    public class Relatorio
    {
        public int Id { get; set; }
        public int AnuncioId { get; set; }
        public float ValorTotalInvestido { get; set; }
        public int QtdMaximaVisualizacoes { get; set; }
        public int QtdMaximaCliques { get; set; }
        public int QtdMaximaCompartilhamentos { get; set; } 

        public Relatorio() { }

        public Relatorio(float p_valorTotalInvestido, int p_qtdMaximaVisualizacoes, int p_qtdMaximaCliques, int p_qtdMaximaCompartilhamentos)
        {
            ValorTotalInvestido = p_valorTotalInvestido;
            QtdMaximaVisualizacoes = p_qtdMaximaVisualizacoes;
            QtdMaximaCliques = p_qtdMaximaCliques;
            QtdMaximaCompartilhamentos = p_qtdMaximaCompartilhamentos;
        }
    }
}
