
namespace Exercicio02
{
    public class Fatura : IImprimivel
    {
        public string Devedor = "";
        public string Credor = "";
        public float Valor = 0;
        public int DiasDeAtraso = 0;
        private float Juros =  0.10f;

        //SObrecarga do Construtor  - obriga a passar os dados na criacao
        public Fatura(string dev, string cred, float valFat, int qtdAtraso)
        {
            Devedor = dev;
            Credor = cred;
            DiasDeAtraso = qtdAtraso;
            Valor = valFat;
        }

        public void Imprimir()
        {
   CalcularValorDivida();

   System.Console.WriteLine($@"
   Credor: {Credor}
   Devedor: {Devedor}
   Dias de atarso: {Devedor} dia(s)
   Valor: R${Valor:F2}
   Juros : {Valor * DiasDeAtraso:F2}
   Total Com Juros R${Valor:F2}
           " );
            
        }

        public void CalcularValorDivida()
        {
            if(DiasDeAtraso > 0)
            {
                Valor = Valor + DiasDeAtraso * Juros;
            } 

            if(DiasDeAtraso >= 5)
            {
                System.Console.WriteLine($"Divida encaminhada para o SERASA");
            } 
        }
    }
}