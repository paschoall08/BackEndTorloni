using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheBasics
{
    public class Aluno : Pessoa
    {
        public Aluno(Endereco endereco) : base(endereco)
        {
        }

        public string RA;

        public float Notafinal;

        public string Curso;
    }
}