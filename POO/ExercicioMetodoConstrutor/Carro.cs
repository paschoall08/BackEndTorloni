using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioMetodoConstrutor
{
    public class Carro
    {
        public string Modelo;
        public string Marca;
        public int Ano;

        public Carro(string mo, string ma, int a)
        {
            Modelo = mo;
            Marca = ma;
            Ano = a;
        }

        public void ExibiDados()
        {
            System.Console.WriteLine($"Carro: {Marca} {Modelo} Ano {Ano}");
        }
    }
}