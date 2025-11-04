/*2) Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time) e informa se
o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.*/

// Entrada de dados
        Console.Write("Informe os gols do primeiro time: ");
        int golsTime1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Informe os gols do segundo time: ");
        int golsTime2 = Convert.ToInt32(Console.ReadLine());

        // Processamento e saída
        if (golsTime1 > golsTime2)
        {
            Console.WriteLine("Vitória do primeiro time!");
        }
        else if (golsTime2 > golsTime1)
        {
            Console.WriteLine("Vitória do segundo time!");
        }
        else
        {
            Console.WriteLine("Empate!");
        }