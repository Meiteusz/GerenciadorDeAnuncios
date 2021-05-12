using Entities;
using Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace Controller
{
    public class AnuncioBLL
    {
        DalAnuncios dalAnuncios = new DalAnuncios();
        DalRelatorios dalRelatorios = new DalRelatorios();

        Calculadora calculadora = new Calculadora();
        Validator validator = new Validator();
        public string Output { get; private set; }

        public bool CadastrarAnuncio(Anuncio anuncio)
        {
            bool isCadastroValido = false;
            string mensagem = ValidarAnuncio(anuncio);

            if (mensagem.Equals(string.Empty) && dalAnuncios.isInsert(anuncio))
            {
                float valorTotalInvestido = (float)anuncio.DataTermino.Subtract(anuncio.DataInicio).TotalDays * anuncio.InvestimentoDia;

                calculadora.CalcularAlcanceAnuncio((int)valorTotalInvestido);//Script para calcular o alcance do anúncio recebendo apenas o valor total que foi investido
                Relatorio relatorio = new Relatorio(valorTotalInvestido, calculadora.TotalVisualizacoes, calculadora.TotalCliques, calculadora.TotalCompartilhamentos);
                
                dalRelatorios.Insert(relatorio);//Relatorio sendo criado e inserido logo após a inserção do anúncio
                isCadastroValido = true;
            }
            Output = dalAnuncios.Output + mensagem;
            return isCadastroValido;
        }

        public Anuncio PegarDadosAnuncio(int IdAnuncio)
        {
            return dalAnuncios.PegarDadosAnuncio(IdAnuncio);
        }

        public AutoCompleteStringCollection ListarNomesCliente()
        {
            return dalAnuncios.PegarNomeClientes();
        }

        public DataTable MostrarAnuncios()
        {
            return dalAnuncios.PegarAnuncios();
        }

        public DataTable FiltrarAnuncios(string nomeCliente, DateTime dataInicio, DateTime dataTermino)
        {
            return dalAnuncios.PegarAnunciosFiltrados(nomeCliente, dataInicio, dataTermino);
        }

        public string ValidarAnuncio(Anuncio anuncio)
        {
            return validator.ValidarNome(anuncio.Nome) + validator.ValidarNomeCliente(anuncio.Cliente) + validator.ValidarInvestimentoDia(anuncio.InvestimentoDia) + validator.ValidarDatas(anuncio.DataInicio, anuncio.DataTermino);
        }
    }
}
