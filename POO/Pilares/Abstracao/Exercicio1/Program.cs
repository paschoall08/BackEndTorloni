using Exercicio1;
Console.Clear();
 ContaCorrente cc = new ContaCorrente();
 ContaPoupanca cp = new ContaPoupanca();

 cc.Depositar(10);
 cp.Depositar(10);

cc.Sacar(10);
cp.Sacar(5);

System.Console.WriteLine($"Saldo Conta corrente: {cc.Saldo}");
System.Console.WriteLine($"Saldo Conta Poupanca: {cp.Saldo}");
cc.Sacar(10);
cp.Sacar(5);

System.Console.WriteLine();

System.Console.WriteLine($"Saldo Conta Conta corrente apos saque: R${cc.Saldo}");
System.Console.WriteLine($"Saldo Poupanca apos saque: R${cp.Saldo}");