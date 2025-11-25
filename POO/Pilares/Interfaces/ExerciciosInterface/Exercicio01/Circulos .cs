using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Circulos : IForma
    {
        public float Raio;
        private float PI = 3.14f;
        public void CalcularArea()
        {
            System.Console.WriteLine($"A area  do Circulo e {PI * Raio * Raio}");
        }
    }
}