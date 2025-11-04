using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primeiraclasse
{

    namespace PrimeiraClasse
    {

        public class Moto
        {

            public int qtdRodas;
            public string marca = "";
            public string modelo = "";
            public string cor = "";

            //métodos
            public void Acelerar()
            {
                Console.WriteLine($"Moto Acelerando");
            }

            public void Frear()
            {
                Console.WriteLine($"Moto Freando");
            }

            public void ligar()
            {
                Console.WriteLine($"Moto Ligando");
            }

            public void Desligar()
            {
                Console.WriteLine($"Moto Desligando");
            }

        }
    }
}