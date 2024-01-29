using System.Data.SqlClient;


namespace Sistema.BancoDados
{

    public class ConexaoDb
    {
        private static string stringConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\egiac\\source\\repos\\Sistema\\Sistema\\BancoDados\\Projeto.mdf;Integrated Security=True;Connect Timeout=30";

        public static SqlCommand Conectar()
        {
            var conexao = new SqlConnection();
            conexao.ConnectionString = stringConexao;
            conexao.Open();
            var comando = conexao.CreateCommand();

            return comando;
        }

    }
}
//cria a conexão, abre e cria o comando. Retorna o comando.