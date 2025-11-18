using Exercicio02;

//Cria uma lista de objetos Fatura
List<IImprimivel> documentos = new List<IImprimivel>();

// Fatura fatLuis = new Fatura("Luis Oliva", "Lacoste", 127, 2);

// fatLuis.Imprimir();


int opcao;
do
{
    Console.Clear();

    // Desenha o Menu
    Console.WriteLine($"Menu de Opções: ");
    Console.WriteLine(@$"
1) Cadastrar Fatura
2) Cadastrar Relatório
3) Cadastrar Contrato
4) Listar Faturas
5) Listar Relatórios
6) Lisar Contratos
0) Sair
Escolha um opção:");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Cadastrar Fatura");
            break;

        case 2:
            Console.WriteLine($"Cadastrar Relatório");
            break;

        case 3:
            Console.WriteLine($"Cadastrar Contrato");
            break;

        case 4:
            Console.WriteLine($"Lstar Faturas");
            break;

        case 5:
            Console.WriteLine($"Listar Rleatórios");
            break;

        case 6:
            Console.WriteLine($"Listar Contratos");
            break;

        case 0:
            Console.WriteLine($"Sair");
            break;

        default:
            Console.WriteLine($"Opção Inválida!");
            break;
    }

    Console.WriteLine($"Digite <Enter> para continuar ...");
    Console.ReadLine(); // Para o console para dar tempo de ver as mensagens do programa

} while (opcao != 0);


// Funções Auuxiliares
void CadastrarFatura()
{
    Console.WriteLine($"Digite o nome do devedor: ");
    string dev = Console.ReadLine();

    Console.WriteLine($"Digite o nome do credor: ");
    string cred = Console.ReadLine();

    Console.WriteLine($"Digite o valor da fatura: ");
    float val = float.Parse(Console.ReadLine());

    Console.WriteLine($"Quantos dias a fatura está em atraso? ");
    int dda = int.Parse(Console.ReadLine());

    // Cria o objeto da fatura
    Fatura f = new Fatura(dev, cred, val, dda);
    // Cadastra a fatura na lista
    documentos.Add(f);
}

void CadastrarContrato()
{
    Console.WriteLine($"Digite o nome do devedor: ");
    string ctr = Console.ReadLine();

    Console.WriteLine($"Digite o nome do Prestador de Servico ");
    string pds = Console.ReadLine();

    Console.WriteLine($"Preencha a clausula ");
    string cls = Console.ReadLine();


    Contrato c = new Cadastro(ctr, pds, cls);
    documentos.Add(c);
}

void CadastrarRelatorio()
{
    Console.WriteLine($"Digite o nome do autor do Relatorio: ");
    string atr = Console.ReadLine();

    Console.WriteLine($"Preencha seu Relatorio: ");
    string rlt = Console.ReadLine();

    Relatorio r = new Relatorio(atr, rlt);
    documentos.Add(r);


    
} 

void ListarFaturas()
{
    Console.WriteLine($"Listando as faturas: ");
    foreach (var item in documentos)
    {
        if (item is Fatura)
        {
            item.Imprimir();
        }
    }
}
void ListarContratos()
{
    System.Console.WriteLine($"Listando os contratos");
     foreach (var item in documentos)
    {
        if (item is Contrato)
        {
            item.Imprimir();
        }
    }
}
void ListarRelatorios ()
{
     Console.WriteLine($"Listando os Relatorios: ");
      foreach (var item in documentos)
    {
        if (item is Relatorios)
        {
            item.Imprimir();
        }
    }
}
