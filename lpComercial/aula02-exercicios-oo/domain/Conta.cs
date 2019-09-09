using System;

namespace aula02_exercicios_oo.domain
{
    public class Conta
    {
        public Conta(int numero, double saldo)
        {
            this.numero = numero;
            this.saldo = saldo;
            this.limite = 100;
        }
        public int numero { get; private set; }
        public double saldo { get; private set; }
        public double limite { get; private set; 
        }
        public void depositar(double valor) => saldo += valor;
        public void sacar(double valor) => saldo -= valor;

        public void transferir(Conta contaDestino, double valor) {
            if(this.saldo > 0 && this.saldo >= valor) {
                contaDestino.depositar(valor);
                this.sacar(valor);   
            } else {
                throw new Exception("Saldo deve ser maior que zero.");
            }
        }
    }
}