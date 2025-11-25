

namespace TheBasics
{
    public class Pessoa
    {
        public string Nome;

        public int Idade;

        public Endereco EnderecoCompleto;

        public Pessoa(Endereco endereco){
            EnderecoCompleto = endereco;

        }

       
        public void Falar()
        {
            Console.WriteLine($"Ola, eu sou{Nome} e tenho {Idade} anos");
        }

        public void Envelhecer()
        {
            Idade++;
        }
    }
}