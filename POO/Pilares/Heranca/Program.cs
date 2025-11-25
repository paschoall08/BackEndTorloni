// using Heranca;
// Console.Clear();


// Veiculo fusca = new Veiculo();
// fusca.Ano = 1979;
// fusca.Modelo = "Fusca 79";
// fusca.Marca = "wolksvagem";

// Carro corola = new Carro();
// corola.Ano = 2005;
// corola.Modelo = "Corolla";
// corola.Marca = "Toyota";


// using Exercicio1;

//  Animal cachorro = new Cachorro();
//  Animal gato = new Gato();


// cachorro.FazerSom(); 
// gato.FazerSom();     

using Exercicio2;

Console.Clear();
using Exercicio2;

Funcionario f1 = new Funcionario();
f1.Nome = "Mangile";
f1.SalarioBase = 5000;

Gerente g1 = new Gerente();
g1.Nome = "Matheus";
g1.SalarioBase = 1000;
g1.Bonus = 2500;

System.Console.WriteLine($"Funcionario : {f1.Nome}, Salario: {f1.CalcularSalario()}");
System.Console.WriteLine($"Gerente : {g1.Nome}, Salario: {g1.CalcularSalario()}");

    