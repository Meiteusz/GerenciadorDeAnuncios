using Entities;

namespace Controller
{
    //Classe feita para ajudar na hora de selecionar um anúncio específico juntamente com seu relatório 
    public static class SetHelper
    {
        public static Anuncio AnuncioSelecionado { get; private set; }
        public static Relatorio RelatorioSelecionado { get; private set; }

        public static void SetAnuncio(int IdAnuncio)
        {
            AnuncioBLL anuncioBLL = new AnuncioBLL();
            AnuncioSelecionado = anuncioBLL.PegarDadosAnuncio(IdAnuncio);
        }

        public static void SetRelatorio(int IdRelatorio)
        {
            RelatorioBLL relatorioBLL = new RelatorioBLL();
            RelatorioSelecionado = relatorioBLL.PegarDadosRelatorio(IdRelatorio);
        }
    }
}
