using ByteBank.Contas;
using ByteBank.Titular;

//instaciando classes de Clientes
Cliente TitularJoão = new Cliente("João", 12345678911, "Analista");
Cliente TitularMaria = new Cliente("Maria", 12345678999, "Desenvolvedora");

//Instaciando classes de contas correntes
ContaCorrente contaJoao = new ContaCorrente(TitularJoão, 15, "1010-X");
ContaCorrente contaMaria = new ContaCorrente(TitularMaria, 15, "1020-X");


Console.WriteLine($"Saldo da conta João R$ {String.Format("{0:0.00}", contaJoao.Saldo)}");
Console.WriteLine($"Saldo da conta Maria R$ {String.Format("{0:0.00}", contaMaria.Saldo)}");

//Realizando um novo deposito a conta corrente do João
contaJoao.DepositarValor(100);

Console.WriteLine("Depositado R$ 100,00 na conta João");

Console.WriteLine($"Saldo da conta João R$ {String.Format("{0:0.00}", contaJoao.Saldo)}");

//Verificando se é possivel realizar o saque do valor informado e caso seja realizando o mesmo na conta corrente do João
if (contaJoao.SacarValor(125) == true)
{
    Console.WriteLine("Sacado R$ 125,00 na conta João");
    Console.WriteLine($"Saldo da conta João R$ {String.Format("{0:0.00}", contaJoao.Saldo)}");
}
else
{
    Console.WriteLine("Saldo Insuficiente para realizar o saque na conta João");
}

//Verificando se existe saldo suficiente para tranferencia e realizando a mesma da conta do João para a conta da Maria
if (contaJoao.TranferirValor(50, contaMaria) == true)
{
    Console.WriteLine("Realizada tranferencia de R$ 50,00 da conta João para a conta Maria");
    Console.WriteLine($"Saldo da conta João R$ {String.Format("{0:0.00}", contaJoao.Saldo)}");
    Console.WriteLine($"Saldo da conta Maria R$ {String.Format("{0:0.00}", contaMaria.Saldo)}");

}
else
{
    Console.WriteLine("Saldo Insuficiente para realizar a tranferencia");
}

Console.WriteLine("----------------------------");
contaJoao.MostrarDados(); 
Console.WriteLine("----------------------------");
contaMaria.MostrarDados();
