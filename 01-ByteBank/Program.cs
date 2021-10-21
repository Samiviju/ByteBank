using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGrabriela = new ContaCorrente();

            contaDaGrabriela.titular = "Gabriela";
            contaDaGrabriela.saldo = 100;
            contaDaGrabriela.agencia = 1001;
            contaDaGrabriela.numero = 85475;

            //Console.WriteLine("Bem vinda " + contaDaGrabriela.titular + " a sua agência é  " + contaDaGrabriela.agencia + " com o número : " + contaDaGrabriela.numero + "  o seu  saldo é  R$"+ contaDaGrabriela.saldo );
            Console.WriteLine("Titular:" +contaDaGrabriela.titular);
            Console.WriteLine("Saldo:R$"+contaDaGrabriela.saldo);
            Console.WriteLine("Agencia:"+contaDaGrabriela.agencia);
            Console.WriteLine("Numero:"+contaDaGrabriela.numero);

            contaDaGrabriela.saldo += 200;
            Console.WriteLine("Saldo:R$" + contaDaGrabriela.saldo);









            Console.ReadLine();
        }
    }
}
