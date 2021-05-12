using System;

namespace Controller
{
    //Classe com funções que validam cada dado antes de irem inseridos para o banco
    public class Validator
    {
        public string ValidarNome(string Nome)
        {
            if (Nome.Length < 3 || Nome.Length > 250)
            {
                return "Nome inválido\n";
            }
            return string.Empty;
        }

        public string ValidarNomeCliente(string NomeCliente)
        {
            if (NomeCliente.Length < 3 || NomeCliente.Length > 80)
            {
                return "Nome do Cliente é inválido\n";
            }
            return string.Empty;
        }

        public string ValidarInvestimentoDia(float InvestimentoDia)
        {
            if (InvestimentoDia <= 0)
            {
                return "Investimento por dia é inválido\n";
            }
            return string.Empty;
        }

        public string ValidarDatas(DateTime dataInicio, DateTime dataTermino)
        {
            if (dataInicio < DateTime.Today)
            {
                return "Data de início é inválida\n";
            }
            if (dataTermino < dataInicio)
            {
                return "Data de término é inválida\n";
            }
            return string.Empty;
        }
    }
}
