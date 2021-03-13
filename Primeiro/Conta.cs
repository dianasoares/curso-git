using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro
{
    class Conta
    {

        public string Numero { get; private set; }
        private string Titular { get; set; }
        public double Saldo { get; private set; }



        public Conta(string titular, string numeroConta)
        {
            this.Titular = titular;
            this.Numero = numeroConta;

        }

        public Conta(string titular, string numeroConta, double depositoInicial) : this(titular, numeroConta)
        {
            this.Saldo = depositoInicial;
        }

        public void detalhes()
        {
            Console.WriteLine(
                $"Conta: {Numero} - " +
                $"Titular: {Titular} - " +
                $"Saldo: {Saldo.ToString("F2")}");

        }

        public bool deposito(double valor)
        {
            if (valor.GetType() == typeof(double))
            {
                Saldo += valor;
                return true;
            }
            else return false;
            
        }

        public bool saque(double valor)
        {
            if (valor.GetType() == typeof(double) && valor<= Saldo)
            {
                Saldo -= ( valor + 5.00) ;
                return true;
            }
            else return false;

        }
    }
}
