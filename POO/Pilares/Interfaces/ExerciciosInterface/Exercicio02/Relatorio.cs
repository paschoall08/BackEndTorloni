

namespace Exercicio02
{
    public class Relatorio : IImprimivel
    {
        public string Nome = "";
        public string TextoRelatorio = "";

        public Relatorio(string responsavel, string TxtoRelatorio)
        {
            Nome = responsavel;
            TextoRelatorio = TxtoRelatorio;
        }
         public void Imprimir()
        {
             System.Console.WriteLine($"Responsavel {Nome}...");
             System.Console.WriteLine(TextoRelatorio);
             System.Console.WriteLine($"--");
        }
    }
}