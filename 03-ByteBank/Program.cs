using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGrabriela = new ContaCorrente();
            contaDaGrabriela.titular = "Gabriela";
            contaDaGrabriela.agencia = 863;
            contaDaGrabriela.numero = 863452;

            ContaCorrente contaDaGrabrielaCosta = new ContaCorrente();
            contaDaGrabriela.titular = "Gabriela";
            contaDaGrabriela.agencia = 863;
            contaDaGrabriela.numero = 863452;

            Console.WriteLine(contaDaGrabriela == contaDaGrabrielaCosta);

            int idade = 27;
            int idadeDeOutraPessoa = 27;
            Console.WriteLine(idade == idadeDeOutraPessoa);

            contaDaGrabriela = contaDaGrabrielaCosta;
            Console.WriteLine(contaDaGrabriela == contaDaGrabrielaCosta);

            contaDaGrabriela.saldo = 300;
            Console.WriteLine(contaDaGrabriela.saldo);
            Console.WriteLine(contaDaGrabrielaCosta.saldo);


            if (contaDaGrabriela.saldo >= 100);
            {
                contaDaGrabriela.saldo -= 100;
            }







        }
    }
}
