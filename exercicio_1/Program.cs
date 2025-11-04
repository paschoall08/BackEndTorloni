
/*1) Faça um programa que o usuário informe o salário recebido e o total gasto. Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto não ultrapasse o valor 
do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.*/

 Console.Write("Informe o salário recebido: ");
        double salario = Convert.ToDouble(Console.ReadLine());

        // Solicita o total gasto
        Console.Write("Informe o total gasto: ");
        double gastos = Convert.ToDouble(Console.ReadLine());

        // Verifica se os gastos ultrapassam o salário
        if (gastos <= salario)
        {
            Console.WriteLine("Gastos dentro do orçamento.");
        }
        else
        {
            Console.WriteLine("Orçamento estourado!");
        }