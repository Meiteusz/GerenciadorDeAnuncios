using Entities;
using System;
using System.Data.SqlClient;

namespace Model
{
    public class DalRelatorios
    {
        Conexao conexao = new Conexao();
        SqlCommand command = new SqlCommand();

        //Funcão responsável por inserir um relatorio na tabela 'Relatorios' do banco de dados
        //Esta funcão é utilizada logo após o anúncio ser cadastrado no banco (o relatório é feito e já cadastrado com o Id do anúncio no mesmo momento que ele é cadastrado)
        public void Insert(Relatorio relatorio)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@valorTotalInvestido", relatorio.ValorTotalInvestido);
            command.Parameters.AddWithValue("@qtdMaximaVisualizacoes", relatorio.QtdMaximaVisualizacoes);
            command.Parameters.AddWithValue("@qtdMaximaCliques", relatorio.QtdMaximaCliques);
            command.Parameters.AddWithValue("@qtdMaximaCompartilhamentos", relatorio.QtdMaximaCompartilhamentos);

            command.CommandText = "insert into Relatorios values(IDENT_CURRENT('Anuncios'), @valorTotalInvestido, @qtdMaximaVisualizacoes, @qtdMaximaCliques, @qtdMaximaCompartilhamentos)";

            command.Connection = conexao.Conectar();
            command.ExecuteNonQuery();
            conexao.Desconectar();
        }


        //Funcão feita com objetivo de pegar os dados de um respectivo relatório pelo Id do anúncio no qual esse relatório pertence
        public Relatorio PegarDadosRelatorios(int p_idAnuncio)
        {
            Relatorio relatorio = new Relatorio();
            SqlCommand command = new SqlCommand("select * from Relatorios where Anuncio_Id = @IdAnuncio", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@IdAnuncio", p_idAnuncio);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                relatorio.Id = (int)reader["Id"];
                relatorio.AnuncioId = (int)reader["Anuncio_Id"];
                relatorio.ValorTotalInvestido = Convert.ToSingle(reader["Valor_Total_Investido"]);
                relatorio.QtdMaximaVisualizacoes = (int)reader["Qtd_Maxima_Visualizacoes"];
                relatorio.QtdMaximaCliques = (int)reader["Qtd_Maxima_Cliques"];
                relatorio.QtdMaximaCompartilhamentos = (int)reader["Qtd_Maxima_Compartilhamentos"];
            }
            conexao.Desconectar();
            return relatorio;
        }
    }
}
