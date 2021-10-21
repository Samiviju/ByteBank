using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var contaDobruno = new ContaCorrente();

            contaDobruno.titular = "Bruno";
            Console.WriteLine(contaDobruno.saldo);
           bool resultadoSaque =  contaDobruno.Sacar(500);
            Console.WriteLine(contaDobruno.saldo);
            Console.WriteLine(resultadoSaque);


            contaDobruno.Depositar(500);
            Console.WriteLine(contaDobruno.saldo);

            var contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo do bruno " + contaDobruno.saldo);
            Console.WriteLine("Saldo da gabriela " + contaDaGabriela.saldo);

            contaDobruno.Trasnferir(200, contaDaGabriela);

            Console.WriteLine("Saldo do bruno " + contaDobruno.saldo);
            Console.WriteLine("Saldo da gabriela " + contaDaGabriela.saldo);


            contaDaGabriela.Trasnferir(100, contaDobruno);
            Console.WriteLine("Saldo do bruno :" + contaDobruno.saldo);
            Console.WriteLine("Saldo da gabriela :" + contaDaGabriela.saldo);



            Console.ReadLine();


        }
    }
}
