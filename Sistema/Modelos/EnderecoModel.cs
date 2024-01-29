namespace Sistema.Modelos
{
    internal class EnderecoModel
    {
        public int Id { get; set; }
        public string Cep { get; set; }
        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Apartamento { get; set; }
        public string Complemento { get; set; }
    }
}
