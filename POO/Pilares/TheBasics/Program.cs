// using System.Runtime.CompilerServices;
using System.Diagnostics.CodeAnalysis;
using TheBasics;

Console.Clear();


// List<Pessoa> peoples = new List<Pessoa>();


// /////////// EDUARDO ////////////////

// Endereco enderecoEdu = new Endereco();
// enderecoEdu.Logradouro = "Rua Niteroi";
// //Pessoa com endereco
// Pessoa edu new Pessoa(enderecoEdu);
// edu.Nome = "Eduardo Costa";
// edu.Idade = 43;


// //////// ALEXIA ///////////////
// Endereco endAlexia = new Endereco();
// endAlexia.Logradouro = "Rua Drausio";
// //Pessoa com endereco
// Pessoa alexia = new Pessoa(endAlexia);
// alexia.Nome = "Alexia Santos";
// alexia.Idade = 30;

// //guardando dados 

// peoples.Add(edu);
// peoples.Add(alexia);

// foreach (var p in peoples)
// {
//     System.Console.WriteLine($"Nome: {p.Nome}");
// }

// Endereco endEnzo = new Endereco();
// endEnzo.Logradouro = "Spinola Teixeira";
// endEnzo.Numero = 3960;
// Aluno pedroEnzo = new Aluno(endEnzo);
// pedroEnzo.Curso = "Desenvolvimento de Sistemas";
// pedroEnzo.RA = "1234-xpto";
// pedroEnzo.Notafinal = 9.75f;

// Endereco endProfAlex = new Endereco();
// endProfAlex.Logradouro = "Rua Drausio";
// endProfAlex.Numero = 987;

// Professor profAlexia = new Professor(endProfAlex);
// profAlexia.Nome = "Alexia Vitoria";

// System.Console.WriteLine($"Aluno {pedroEnzo.Nome} estuda na turma {pedroEnzo.Curso} da prof.{profAlexia}");


Carro fusca = new Carro();
fusca.Marca = "wolksvagem";
fusca.Modelo = "Fusca";

Moto dominar400 = new Moto();
dominar400.Marca = "Bajaj";
dominar400.Modelo = "Dominar 400";

fusca.Ligar();
fusca.AbirPortaMala();

dominar400.Ligar();
dominar400.Desligar();