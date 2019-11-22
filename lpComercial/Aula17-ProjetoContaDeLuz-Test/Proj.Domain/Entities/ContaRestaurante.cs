using System;

namespace Proj.Domain.Entities
{
    public class ContaRestaurante : Entity
    {
        public ContaRestaurante() { }

        public ContaRestaurante(DateTime dataAlmoco, DateTime dataPagamento, double kgGasto, double valorAPagar, double mediaGasto, int idRestaurante, Restaurante restaurante)
        {
            this.dataAlmoco = dataAlmoco;
            this.dataPagamento = dataPagamento;
            this.kgGasto = kgGasto;
            this.valorAPagar = valorAPagar;
            this.mediaGasto = mediaGasto;
            this.idRestaurante = idRestaurante;
            this.restaurante = restaurante;
        }

        public DateTime dataAlmoco { get; set; }
        public DateTime dataPagamento { get; set; }
        public double kgGasto { get; set; }
        public double valorAPagar { get; set; }
        public double mediaGasto { get; set; }
        public int idRestaurante { get; set; }
        public Restaurante restaurante { get; set; }
    }
}