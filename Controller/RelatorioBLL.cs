using Entities;
using Model;

namespace Controller
{
    public class RelatorioBLL
    {
        DalRelatorios dalRelatorios = new DalRelatorios();

        public Relatorio PegarDadosRelatorio(int IdAnuncio)
        {
            return dalRelatorios.PegarDadosRelatorios(IdAnuncio);
        }
    }
}
