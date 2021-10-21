
namespace _05_ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        public double saldo = 100;

        public bool Sacar(double valor)//Funcão para Sacar um dinheiro
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;

            }
        }

        public void Depositar(double valor) //Método para depositar 
        {
            this.saldo += valor;
        }

        public bool Trasnferir(double valor, ContaCorrente contaDestino) //Transferencias de contas
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                contaDestino.Depositar(valor);
                return true;


            }


        }

    }
}







