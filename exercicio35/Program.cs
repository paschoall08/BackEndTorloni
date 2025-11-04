/* Faca um programa que solicite ao usuario um numero de repeticoes "x". pra cada repeticao solicite 
dois numeros e imprima qual e o maior deles*/

Console.Write("Digite o número de repetições: ");
        int x = int.Parse(Console.ReadLine());

        for (int i = 1; i <= x; i++)
        {
            Console.WriteLine($"\nRepetição {i}:");

            Console.Write("Digite o primeiro número: ");
            double numero1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double numero2 = double.Parse(Console.ReadLine());

            while (numero1 > numero2)
           {
               Console.WriteLine($"O maior número é: {numero1}");
            }
            
            else  if (numero2 > numero1)
            {
                Console.WriteLine($"O maior número é: {numero2}");
            }
            else
            {
                Console.WriteLine("Os dois números são iguais.");
            }
        }

        Console.WriteLine("Fim do programa.");
    