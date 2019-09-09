using System;

namespace aula02_exercicios_oo.domain
{
    public class CartaoCredito
    {
        public CartaoCredito(string numero, DateTime validadeCartao, Cliente cliente)
        {
            this.numero = numero;
            this.validadeCartao = validadeCartao;
            this.cliente = cliente;
        }
        public string numero { get; private set; }
        public DateTime validadeCartao { get; private set; }
        public Cliente cliente { get; set; }
    }
}