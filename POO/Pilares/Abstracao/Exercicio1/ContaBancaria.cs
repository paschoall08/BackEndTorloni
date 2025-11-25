using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio1
{
    public abstract class ContaBancaria
    {

        double Saldo = 0;

        public abstract void Depositar(double deposito);

        public abstract void Sacar(double saque);
    }
}