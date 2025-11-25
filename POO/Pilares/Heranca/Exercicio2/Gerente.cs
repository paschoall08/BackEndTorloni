Console.Clear();

namespace Exercicio2
{
    public class Gerente : Funcionario
    {
        public double Bonus;

        public double CalcularSalario()
        {
            return SalarioBase + Bonus;
        }
    }
}
