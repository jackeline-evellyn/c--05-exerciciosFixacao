using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Banco
{
    class Conta
    {
        public int Numero { get; private set; }
        public double Saldo { get; set; }
        public string Titular { get; private set; }
       
        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0.0;
        }
        public Conta(int numero, string titular, double saldo):this(numero, titular)
        {
           
            Saldo = saldo;
        }

        public override string ToString()
        {
            return "Conta "
                + Numero 
                + ", Titular: " 
                + Titular 
                + ", Saldo: $ " 
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);

        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        public void Saque (double quantia)
        {
            Saldo -= quantia;
            Saldo -= 5.0;
        }

    }
}
