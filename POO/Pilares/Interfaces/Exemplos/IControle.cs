

namespace Exemplos
{
    public interface IControle
    {
        public int NivelVolume {get; set;}
        void Ligar();
        void Desligar();
        void AumentarVolume();
        void DiminuirVolume();

    }
}