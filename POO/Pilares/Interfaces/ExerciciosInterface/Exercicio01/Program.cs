// Exercício 1
// Crie uma interface chamada IForma com o método CalcularArea.
// Crie duas classes que implementem essa interface: Retangulo e Circulo.
// No programa, peça os valores necessários e exiba a área calculada para cada forma.
// No Retângulo utilizar o cálculo = Largura * Altura;
// No Círculo utilizar o cálculo = PI * Raio * Raio;
// Extra: Pesquisar sobre a classe Mth do C# e utilizar a constante PI - Math.PI


//Retangulo

using System.Linq.Expressions;
using Exercicio01;

System.Console.WriteLine($"Bem-Vindo ao programa Calculos de Geometria :)");
System.Console.WriteLine();

System.Console.WriteLine($"Vamos Calcular");

//Altura e Largura 
System.Console.Write($"Digite a largura do Retangulo");
float l = float.Parse(Console.ReadLine());
System.Console.Write($"Digite a altura do Retangulo");
float a = float.Parse(Console.ReadLine());

Retangulo retangulo = new Retangulo();
retangulo.Altura = a;
retangulo.Largura = l;
retangulo.CalcularArea();

System.Console.WriteLine()
Console.WriteLine($"Agora vamos calcular a area do circulo");

System.Console.WriteLine($"Informe o raio do circulo:");
float r = float.Parse(Console.ReadLine());

Circulos circulos = new Circulos();
circulos.Raio = r;
circulos.CalcularArea();

System.Console.WriteLine();
System.Console.WriteLine($"Fim do Programa");
System.Console.WriteLine();