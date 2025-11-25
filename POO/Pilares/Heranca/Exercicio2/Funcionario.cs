
namespace Exercicio2
{
    public class Funcionario
    {
        public string Nome;
    public double SalarioBase;

    public virtual double CalcularSalario()
    {
        return SalarioBase;
    }
    }
}