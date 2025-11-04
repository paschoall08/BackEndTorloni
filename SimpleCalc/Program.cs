using System.Diagnostics;

string nome;
int numero1;
int numero2;

// pedir os nomes pro usuario 
Console.WriteLine("Paschoall");
string Nome = Console.ReadLine();


//pedir os numeros 
Console.WriteLine("Digite o primeiro numero");
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo numero");
numero2 = int.Parse(Console.ReadLine());

//somar os doisa numeros 
int soma = numero1 + numero2;

// exibir nome e soma 
Console.WriteLine(Nome);
Console.WriteLine(soma);


