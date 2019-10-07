using System;
namespace aula05.domain
{
    public class CartaoCredito
    {
        public CartaoCredito(int numero, DateTime dataValidade, Cliente cliente)
        {
            this.numero = numero;
            this.dataValidade = dataValidade;
            this.cliente = cliente;
        }
        public int numero { get; set; }
        public DateTime dataValidade { get; set; }
        public Cliente cliente { get; set; }
    }
}