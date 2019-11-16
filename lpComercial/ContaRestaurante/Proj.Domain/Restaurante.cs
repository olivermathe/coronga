namespace restaurante.domain {
    public class Restaurante {
        //Não esquecer de criar um construtor vazio para o EFF

        public Restaurante(){}
        public Restaurante (int id, string nome, string endereco, int numero, string cidade, string estado) {
            this.id = id;
            this.nome = nome;
            this.endereco = endereco;
            this.numero = numero;
            this.cidade = cidade;
            this.estado = estado;

        }
        public int id { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }

    }

}