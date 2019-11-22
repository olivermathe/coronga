using System;

namespace Proj.Domain.Entities { //tem que usar o domain do restaurante pq o consumo se refere a um restaurante
    public class Consumo : Entity {

        public Consumo() { }

        public Consumo (int idRestaurante, Restaurante restaurante, DateTime data, double valor) {
         
            this.idRestaurante = idRestaurante;
            this.restaurante = restaurante;
            this.data = data;
            this.valor = valor;
        }
        public int idRestaurante { get; set; } //para identificar de qual restaurante a conta esta referenciando
        public Restaurante restaurante { get; set; }
        public DateTime data { get; set; }
        public double valor { get; set; }
    }
}