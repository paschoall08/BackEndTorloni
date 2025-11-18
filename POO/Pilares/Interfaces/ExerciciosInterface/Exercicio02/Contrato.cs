

namespace Exercicio02
{
    public class Contrato : IImprimivel
    {
        public string Contratante = "";
        public string PrestorServico = "";
        public string TextoClausulas = "";
        public void Imprimir()
        {
            Console.WriteLine($@"
            Partes :
              Contratante { Contratante}
              Contratada { PrestorServico}
              Clausulas do Contrato: 
              
              {TextoClausulas}
              ---
              ");
            
        }
    }
}