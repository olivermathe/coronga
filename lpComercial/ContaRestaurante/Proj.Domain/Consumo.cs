namespace restaurante.domain { //tem que usar o domain do restaurante pq o consumo se refere a um restaurante
    public class Consumo {
        public int id { get; set; }
        public Restaurante restaurante { get; set; } 
        public string data { get; set; }
        public double valor { get; set; }
    }
}