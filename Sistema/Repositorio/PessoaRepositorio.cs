using Sistema.Modelos;
using Sistema.BancoDados;

namespace Sistema.Repositorio
{
    internal class PessoaRepositorio
    {
        public void Cadastrar(PessoaModel pessoa)
        {
            var comando = ConexaoDb.Conectar();
            comando.CommandText = "INSERT INTO pessoas (NOME, SOBRENOME, TELEFONE, CPF, SENHA, ENDERECO) VALUES (@NOME, @SOBRENOME, @TELEFONE, @CPF, @SENHA, @ENDERECO)";
            comando.Parameters.AddWithValue("@NOME", pessoa.Nome);
            comando.Parameters.AddWithValue("@SOBRENOME", pessoa.Sobrenome);
            comando.Parameters.AddWithValue("@TELEFONE", pessoa.Telefone);
            comando.Parameters.AddWithValue("@CPF", pessoa.Cpf);
            comando.Parameters.AddWithValue("@SENHA", pessoa.Senha);
            comando.Parameters.AddWithValue("@ENDERECO", pessoa.Endereco.Id);

            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            comando.Connection.Close();
        }
    }
}
