using ViaCepConsumer;
using ViaCepConsumer.Models;

namespace Sistema.Repositorio
{
     internal class BuscaCepRepositorio
    {
        public static SearchResult BuscarCep(string cep)
        {
            ViaCepClient viaCepClient = new ViaCepClient();
            var resultado = viaCepClient.Search(cep);

            return resultado;
        }
    }
}
