
namespace _06_ByteBank
{
    public class ContaCorrente
    { 
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
    
        private double _saldo = 100;


        public double Saldo
        {
            get // get = Obter
            {
                return _saldo;
            }
            set //set = Definir 
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    _saldo = value;
                }
            }
        }



        public bool Sacar(double valor)//Funcão para Sacar um dinheiro
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;

            }
        }

        public void Depositar(double valor) //Método para depositar 
        {
            this._saldo += valor;
        }

        public bool Trasnferir(double valor, ContaCorrente contaDestino) //Transferencias de contas
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }


        }

    }
}







