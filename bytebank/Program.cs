
using bytebank;


ContaCorrente conta1= new ContaCorrente(11111, "ZZZZZZ-ZZ");
Cliente cliente2 = new Cliente();
cliente2.Nome = "José";
conta1.Titular = cliente2;
conta1.Saldo = 10000;
Console.WriteLine("Saldo" + conta1.Saldo);
Console.WriteLine("Titular: " + conta1.Titular.Nome);

ContaCorrente conta2 = new ContaCorrente(55555, "YYYYYY-Y");
Cliente cliente1 = new Cliente();
conta2.Saldo = 1100;

Console.WriteLine("Saldo: " + conta2.Saldo);
conta2.Sacar(20);
Console.WriteLine("Saldo após saque: " + conta2.Saldo);
conta2.Depositar(100);
Console.WriteLine("Saldo após deposito: " + conta2.Saldo);

// --------------------------------------- //
Console.WriteLine("Saldo conta1 antes da transferência: " + conta1.Saldo);
Console.WriteLine("Saldo conta2 antes da transferência: " + conta2.Saldo);

bool transferencia = conta1.Transferir(50, conta2);

Console.WriteLine("Transferência realizada com sucesso? " + transferencia);
Console.WriteLine("Saldo conta1 após a transferência: " + conta1.Saldo);
Console.WriteLine("Saldo conta2 após a transferência: " + conta2.Saldo);
                                        

ContaCorrente conta3 = new ContaCorrente(77777, "TTTTT-T");
Cliente cliente3 = new Cliente();
cliente3.Nome = "Ariane";
conta3.Titular = cliente3; // referenciando classe Cliente
Console.WriteLine(conta3.Titular.Nome);

conta3.Saldo = 150;
Console.WriteLine("getSaldo: " + conta3.Saldo);
// -----
ContaCorrente conta8 = new ContaCorrente(2535, "125358-X");

ContaCorrente conta9= new ContaCorrente(365, "957256-X");
Console.WriteLine("Total de contas criadas " + ContaCorrente.TotalDeContasCriadas);





