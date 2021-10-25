using System;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            ContaCorrente conta = new ContaCorrente(867, 8671454);


            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contaDaGabriela = new ContaCorrente(867, 678657577);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
             
            Console.WriteLine("Ola!");

            Console.ReadLine();


        }
    }
}
