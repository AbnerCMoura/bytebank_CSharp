using bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Conta
{
    public class ContaCorrente
    {

        public static int TotalContasCriadas { get; private set; }
        private int numero_agencia;
        public int Numero_agencia
        {
            get { return this.numero_agencia; }
            private set
            {
                if (value > 0)
                {
                    this.numero_agencia = value;
                }
            }
        }
        public string Conta { get; private set; }

        private double saldo;

        public double Saldo {
            get { return this.saldo; }
            private set {
                if (value > 0)
                    {
                        this.saldo = value;
                    }
            }
        }

        public DadosCliente Titular { get; set; }

        public void Depositar(double valorDepositado)
        {
            this.saldo += valorDepositado;
        }

        public bool Sacar(double valorSaque)
        {
            if(valorSaque > this.saldo)
            {
                return false;
            }
            else
            {
                this.saldo -= valorSaque;
                return true;
            }
        }
        public bool Tranferir(double valor, ContaCorrente destino)
        {
            if (valor > this.saldo)
            {
                return false;
            }
            else
            {
                this.Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }
        public ContaCorrente(int num_agencia, string num_conta, double saldo)
        {
            Saldo = saldo;
            this.numero_agencia = num_agencia;
            this.Conta = num_conta;
            TotalContasCriadas++;
        }
    }
}
