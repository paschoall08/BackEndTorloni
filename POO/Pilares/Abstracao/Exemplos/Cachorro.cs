using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Cachorro : Animal
    {
        public override void FazerSom()
        {
            System.Console.WriteLine($"Au au!");
        }

        public override void Mover()
        {
            System.Console.WriteLine($"Ploc ,Ploc");
        }
    }
}