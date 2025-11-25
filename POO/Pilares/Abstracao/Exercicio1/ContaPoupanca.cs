using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class ContaPoupança : ContaBancaria
    {

        public double Saldo = 0;

        public override void Depositar(double deposito)
        {
            throw new NotImplementedException();
            if(deposito <= 0)
            {
                System.Console.WriteLine($"O valor do deposito dever ser maior que de R$0,00");
                return;
            }
        
            Saldo += deposito;
        }

        public override void Sacar(double saque)
        {
            throw new NotImplementedException();
            
        if (Saldo <= saque)
        {
            System.Console.WriteLine($"Não pode efetuar o saque");
            return;
        }

        saque = Saldo * 0.2;

        }



    }
}