/*faca um programa que pergunte para o usuario a quantidade de numeros que ele 
quer digitar. Apos isso crie um laco que exiba o numero que o usuario digitar apenas 
se for PAR. Utilize a estrutura while.*/


int contador = 0;

Console.WriteLine("Quantos numeros voce deseja digitar?");
int numerodig = int.Parse(Console.ReadLine());



while (contador < numerodig)
{
    Console.Write($"Digite o {contador + 1}º número: ");
    int numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 0)
    {
        Console.WriteLine($" é PAR {numero}.");
    }
    contador++;
}