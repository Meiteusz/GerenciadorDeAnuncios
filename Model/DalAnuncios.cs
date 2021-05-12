using Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Model
{
    public class DalAnuncios
    {
        Conexao conexao = new Conexao();
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter;
        DataTable dt;
        public string Output { get; private set; }

        //Funcão responsável por inserir um anúncio na tabela de 'Anúncios' do banco de dados
        public bool isInsert(Anuncio p_anuncio)
        {
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@Nome", p_anuncio.Nome);
            command.Parameters.AddWithValue("@Cliente", p_anuncio.Cliente);
            command.Parameters.AddWithValue("@DataInicio", p_anuncio.DataInicio);
            command.Parameters.AddWithValue("@DataTermino", p_anuncio.DataTermino);
            command.Parameters.AddWithValue("@InvestimentoDia", p_anuncio.InvestimentoDia);
            command.CommandText = "insert into Anuncios values(@Nome, @Cliente, @DataInicio, @DataTermino, @InvestimentoDia)";

            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                Output = "Erro com o Banco de Dados\n" + ex.Message;
                return false;
            }
            finally
            {
                conexao.Desconectar();
            }
        }


        //Funcão feita com objetivo de pegar os dados de um respectivo anúncio pelo Id, é muito útil na parte de visualizaçaõ de um anúncio específico e
        //também para futuras implementações
        public Anuncio PegarDadosAnuncio(int p_idAnuncio)
        {
            Anuncio anuncio = new Anuncio();
            SqlCommand command = new SqlCommand("select * from Anuncios where Id = @IdAnuncio", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@IdAnuncio", p_idAnuncio);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                anuncio.Id = (int)reader["Id"];
                anuncio.Nome = reader["Nome"].ToString();
                anuncio.Cliente = reader["Cliente"].ToString();
                anuncio.DataInicio = Convert.ToDateTime(reader["Data_Inicio"]);
                anuncio.DataTermino = Convert.ToDateTime(reader["Data_Termino"]);
                anuncio.InvestimentoDia = Convert.ToSingle(reader["Investimento_Dia"]);
            }
            conexao.Desconectar();
            return anuncio;
        }


        //Funcão feita para pegar todos os nomes dos clientes cadastrados no sistema para dar como resultado na pesquisa de anúncios (AutoComplete)
        public AutoCompleteStringCollection PegarNomeClientes()
        {
            AutoCompleteStringCollection clientes = new AutoCompleteStringCollection();
            adapter = new SqlDataAdapter("select Cliente from Anuncios", conexao.Conectar());
            dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                clientes.Add(item["Cliente"].ToString());
            }
            conexao.Desconectar();
            return clientes;
        }


        //Funcão que seleciona todos os anúncios cadastrados no banco para mostrar na tabela de relatórios (GridView)
        public DataTable PegarAnuncios()
        {
            SqlCommand command = new SqlCommand("select a.Id, a.Cliente, FORMAT(a.Data_Inicio, 'dd/MM/yyyy') as Data_Inicio, FORMAT(a.Data_Termino, 'dd/MM/yyyy') as " +
                "Data_Termino, FORMAT(r.Valor_Total_Investido, 'c', 'pt-br') as Investimento_Total, r.Qtd_Maxima_Visualizacoes as Qtd_Max_Visualizacoes, " +
                "r.Qtd_Maxima_Cliques as Qtd_Max_Cliques, r.Qtd_Maxima_Compartilhamentos as Qtd_Max_Compartilhamentos from Anuncios a inner join Relatorios r on " +
                "r.Anuncio_Id = a.Id; ", conexao.Conectar());
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            conexao.Desconectar();
            return dt;
        }


        //Funcão que seleciona todos os anúncios com os filtros: Nome do cliente, e o intervalo de tempo para mostrar na tabela de relatórios (GridView)
        public DataTable PegarAnunciosFiltrados(string p_nomeCliente, DateTime p_dataInicio, DateTime p_dataTermino)
        {
            SqlCommand command = new SqlCommand ("select a.Id, a.Cliente, FORMAT(a.Data_Inicio, 'dd/MM/yyyy') as Data_Inicio, FORMAT(a.Data_Termino, 'dd/MM/yyyy') as " +
                "Data_Termino, FORMAT(r.Valor_Total_Investido, 'c', 'pt-br') as Investimento_Total, r.Qtd_Maxima_Visualizacoes as Qtd_Max_Visualizacoes, " +
                "r.Qtd_Maxima_Cliques as Qtd_Max_Cliques, r.Qtd_Maxima_Compartilhamentos as Qtd_Max_Compartilhamentos from Anuncios a inner join Relatorios r on " +
                "r.Anuncio_Id = a.Id where a.Cliente = @nomeCliente or a.Data_Inicio >= CONVERT(date, @dataInicio) and a.Data_Termino <= CONVERT(date, @dataTermino)", conexao.Conectar());
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nomeCliente", p_nomeCliente);
            command.Parameters.AddWithValue("@dataInicio", p_dataInicio);
            command.Parameters.AddWithValue("@dataTermino", p_dataTermino);
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            conexao.Desconectar();
            return dt;
        }
    }
}
