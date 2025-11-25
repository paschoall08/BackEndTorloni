// See https://aka.ms/new-console-template for more information
// using System.Runtime.Intrinsics.X86;
// using ClassesEstaticas;

// Console.WriteLine("Bem Vindo ao Programa ");
// System.Console.WriteLine();

// Console.Write($"Digite um numero:");
// float a = float.Parse(Console.ReadLine());
// System.Console.WriteLine($"Digite outro numero");
// float b  = float.Parse(Console.ReadLine());

// float r = CalculosMatematicos.Somar(a + b);
// Console.WriteLine($"Soma: {r}");

// r = CalculosMatematicos.Subtrair(a ,b);
// Console.WriteLine($"Subtracao: {r}");


// r = CalculosMatematicos.Multiplicar(a ,b);
// Console.WriteLine($"Miltiplicacao: {r}");

// r = CalculosMatematicos.Dividir(a ,b);
// Console.WriteLine($"Divisao: {r}");


/*solicitar ao usuario 2 numeros reais e informar qual
e o maior e qual e o menor dos numeros. Para isso voce deve
utilizar a classe Math, utilitaria do C#*/
Console.WriteLine($"Digite o primeiro numero: ");
float n1 = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite o segundo numero: ");
float n2 = float.Parse(Console.ReadLine());

if (n1== n2)
{
    System.Console.WriteLine($" Os dois numeros sao iguais");
}
else
{
   System.Console.WriteLine($@" O maior numero e: {Math.Max(n1, n2)}
                             o numero menor e: {Math.Min(n1, n2)}");
}
