using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BytebankEx
{
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }
        public static double TaxaOperacao { get; private set; }

        public Cliente Cliente { get; set; }

        public int Numero { get; }
        public int Agencia { get; }


        private double _saldo = 100;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                _saldo = value;
            }

        }

        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0 || numero <= 0 )
            {
                throw new Exception("O número e a agencia devem ser maior que 0!");
            }
            Agencia = agencia;
            Numero = numero;
            TaxaOperacao = 30 / TotalDeContasCriadas;
            TotalDeContasCriadas++;
        }

        public bool Sacar(double valor)
        {

            if (_saldo < valor || valor <= 0)
            {
                return false;
            }

            _saldo -= valor;
            return true;

        }

        public bool Depositar(double valor)
        {
            if (valor > 0)
            {
                _saldo += valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(ContaCorrente contaCorrenteDestino, double valor)
        {
            if (_saldo < valor || valor <= 0)
            {
                return false;
            }
            Sacar(valor);
            contaCorrenteDestino.Depositar(valor);
            return true;
        }

    }

}
