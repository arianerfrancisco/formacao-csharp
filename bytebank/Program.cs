
using bytebank;

/*
ContaCorrente conta1= new ContaCorrente();
Cliente cliente2 = new Cliente();
cliente2.nome = "José";

conta1.saldo = 2000;
Console.WriteLine("Titular: " + cliente2.nome);

ContaCorrente conta2 = new ContaCorrente();
Cliente cliente1 = new Cliente();
conta2.saldo = 1100;

Console.WriteLine("Saldo: " + conta2.saldo);
conta2.Sacar(20);
Console.WriteLine("Saldo após saque: " + conta2.saldo);
conta2.Depositar(100);
Console.WriteLine("Saldo após deposito: " + conta2.saldo);

// --------------------------------------- //
Console.WriteLine("Saldo conta1 antes da transferência: " + conta1.saldo);
Console.WriteLine("Saldo conta2 antes da transferência: " + conta2.saldo);

bool transferencia = conta1.Transferir(50, conta2);

Console.WriteLine("Transferência realizada com sucesso? " + transferencia);
Console.WriteLine("Saldo conta1 após a transferência: " + conta1.saldo);
Console.WriteLine("Saldo conta2 após a transferência: " + conta2.saldo);
*/

ContaCorrente conta3 = new ContaCorrente();
Cliente cliente3 = new Cliente();
cliente3.nome = "Ariane";
conta3.titular = cliente3; // referenciando classe Cliente
Console.WriteLine(conta3.titular.nome);




