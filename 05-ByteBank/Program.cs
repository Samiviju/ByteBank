using System;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //var gabriela = new Cliente();

            //gabriela.nome = "gabriela";
            //gabriela.profissao = "Desenvolvedora CSharp";
            //gabriela.cpf = "434.562.878-78";


            var conta = new ContaCorrente();

            //conta.titular = new Cliente();


            if(conta.titular == null)
            {
                Console.WriteLine("Ops, a referência em conta.titular é NULL");
            }


            

            

            //conta.titular.nome = "Gabriela Costa";
            //conta.titular.cpf = "434.562.878-78";
            //conta.titular.profissao = "Desenvolvedora Csharp";

            //Console.WriteLine(conta.titular.nome);
            //Console.WriteLine(conta.titular.cpf);
            //Console.WriteLine(conta.titular.profissao);




            //conta.titular = gabriela;
            //conta.saldo = 500;
            //conta.agencia = 563;
            //conta.numero = 5634578;


            //Console.WriteLine(gabriela.nome);

            Console.ReadLine();

            

        }
    }
}
