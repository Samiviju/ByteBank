using System;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Samuel";
            conta.saldo = 200;


            Console.WriteLine("Titular:"+conta.titular);
            Console.WriteLine("Agencia:"+conta.agencia);
            Console.WriteLine("Saldo:R$"+conta.saldo);

            Console.ReadLine();


        }
    }
}
