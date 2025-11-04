/*3) Escreva     um     programa que leia     as     medidas     dos     lados     de     um     triângulo     e    escreva    se    ele    é    Equilátero,    Isósceles    ou    Escaleno.    Sendo    que:     

   − Triângulo    Equilátero:    possui    os    3    lados    iguais.     
   − Triângulo    Isóscele:    possui    2    lados    iguais.     
   − Triângulo    Escaleno:    possui    3    lados    diferentes*/

   
    Console.Write("Informe o valor do primeiro lado: ");
        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o valor do segundo lado: ");
        double lado2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe o valor do terceiro lado: ");
        double lado3 = Convert.ToDouble(Console.ReadLine());

        // Verifica se as medidas formam um triângulo
        if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
        {
            // Classificação do triângulo
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("Triângulo Equilátero: possui os 3 lados iguais.");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("Triângulo Isósceles: possui 2 lados iguais.");
            }
            else
            {
                Console.WriteLine("Triângulo Escaleno: possui os 3 lados diferentes.");
            }
        }
        else
        {
            Console.WriteLine("As medidas informadas não formam um triângulo!");
        }