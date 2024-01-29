﻿using Sistema.Modelos;
using Sistema.Repositorio;


namespace Sistema.Telas
{
    public partial class PessoasForm : Form
    {
        public PessoasForm()
        {
            InitializeComponent();
        }

        private void textBoxCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxCep.Text.Length == 8)
                {
                    var cep = textBoxCep.Text;
                    var resultado = BuscaCepRepositorio.BuscarCep(cep);

                    textBoxUf.Text = resultado.EstadoUf;
                    textBoxBairro.Text = resultado.Bairro;
                    textBoxCidade.Text = resultado.Cidade;
                    textBoxRua.Text = resultado.Rua;
                }
                else
                {
                    MessageBox.Show("Preencha o campo CEP corretamente!");
                }
            }
        }

        private void buttonLimparEndereco_Click(object sender, EventArgs e)
        {
            textBoxUf.Clear();
            textBoxBairro.Clear();
            textBoxCidade.Clear();
            textBoxRua.Clear();
            textBoxCep.Clear();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {

            if(textBoxCep.Text == string.Empty || textBoxUf.Text == string.Empty || textBoxBairro.Text == string.Empty || textBoxRua.Text == string.Empty || textBoxNumero.Text == string.Empty || textBoxCidade.Text == string.Empty) 
            {
                MessageBox.Show("Preencha os campos corretamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var endereco = new EnderecoModel();
            endereco.Cep = textBoxCep.Text;
            endereco.Uf = textBoxUf.Text;
            endereco.Cidade = textBoxCidade.Text;
            endereco.Bairro = textBoxBairro.Text;
            endereco.Rua = textBoxRua.Text;
            endereco.Numero = textBoxNumero.Text;
            endereco.Apartamento = textBoxApartamento.Text;
            endereco.Complemento = textBoxComplemento.Text;

            EnderecoRepositorio.CadastrarEndereco(endereco);
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxNome.Clear();
            textBoxSobrenome.Clear();
            textBoxSenha.Clear();
            maskedTextBoxCpf.Clear();
            maskedTextBoxTelefone.Clear();
        }
    }
}
