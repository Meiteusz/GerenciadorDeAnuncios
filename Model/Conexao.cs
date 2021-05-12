using System.Data.SqlClient;
using System.Data;

namespace Model
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        //Construtor com a string de conexão do usuário, utilizada para nao ter a necessidade de inserir a string de conexão toda vez que for conectar ao banco
        public Conexao()
        {
            con.ConnectionString = "Data Source=.;Initial Catalog=GerenciadorDeAnuncios;Integrated Security=True";
        }

        //Funcão que retorna o estado da conexão, se estiver fechada, irá ser aberta quando chamada
        public SqlConnection Conectar()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        //Funcão que quando chamada fecha a conexão se estiver aberta
        public void Desconectar()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
