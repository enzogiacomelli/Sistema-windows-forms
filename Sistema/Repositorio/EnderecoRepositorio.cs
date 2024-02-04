using Sistema.Modelos;
using Sistema.BancoDados;

namespace Sistema.Repositorio
{
    internal class EnderecoRepositorio
    {
        public void Cadastrar(EnderecoModel endereco)
        {
            var comando = ConexaoDb.Conectar();
            comando.CommandText = "INSERT INTO endereco (CEP, UF, CIDADE, BAIRRO, RUA, NUMERO, APARTAMENTO, COMPLEMENTO) VALUES (@CEP, @UF, @CIDADE, @BAIRRO, @RUA, @NUMERO, @APARTAMENTO, @COMPLEMENTO)";
            comando.Parameters.AddWithValue("@CEP", endereco.Cep);
            comando.Parameters.AddWithValue("@UF", endereco.Uf);
            comando.Parameters.AddWithValue("@CIDADE", endereco.Cidade);
            comando.Parameters.AddWithValue("@BAIRRO", endereco.Bairro);
            comando.Parameters.AddWithValue("@RUA", endereco.Rua);
            comando.Parameters.AddWithValue("@NUMERO", endereco.Numero);
            comando.Parameters.AddWithValue("@APARTAMENTO", endereco.Apartamento);
            comando.Parameters.AddWithValue("@COMPLEMENTO", endereco.Complemento);

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

        public int BuscarUltimoIdCadastrado()
        {
            var comando = ConexaoDb.Conectar();
            comando.CommandText = "SELECT TOP 1 id FROM endereco ORDER BY id DESC";

            var id = comando.ExecuteNonQuery();
            comando.Connection.Close();
            return id;
        }
    }
}
