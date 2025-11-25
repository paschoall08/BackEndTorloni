using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class ContaBancaria
    {
        public float Saldo ;

        public ContaBancaria()
        {
            Saldo = 0;
        }

        public ContaBancaria(float saldoInicial)
        {
            Saldo = saldoInicial
        }
        
        public void Depositar(float valor)
        {
            if(valor >= 0 )
            {
            Saldo = valor;
            return;
            }
        }

        public float GetSaldo()
    
        {
             return Saldo;
        }

        public void Saque (float valor)
        {
            if(valor >= 0 && valor <= Saldo);
            {
            Saldo -= valor;
            System.Console.WriteLine($"saque efetuado cm sucesso");
            return;
            }

            System.Console.WriteLine($"Valor para saque invalido");
        }

        
    }
} 