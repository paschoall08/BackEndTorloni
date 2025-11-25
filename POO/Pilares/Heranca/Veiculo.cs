
namespace Heranca
{
    public class Veiculo
    {
        public string Marca;
        public string Modelo;
        public int Ano;

        public virtual void Acelerar()
        {
            System.Console.WriteLine($"Acelerando o Veiculo");
        }
    }
}