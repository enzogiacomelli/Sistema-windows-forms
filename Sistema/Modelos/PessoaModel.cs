﻿namespace Sistema.Modelos
{
    internal class PessoaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }
        public EnderecoModel Endereco { get; set; }
    }
}
