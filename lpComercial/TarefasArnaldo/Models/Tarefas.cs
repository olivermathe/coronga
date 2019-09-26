namespace TarefasArnaldo.Models
{
    public class Tarefas
    {
        public Tarefas() //o eff precisa de um construtor vazio para trabalhar com as instancias
        { }
        public Tarefas(int id, string name, string dataLimite, int percentConcluido)
        {
            this.id = id;
            this.name = name;
            this.dataLimite = dataLimite;
            this.percentConcluido = percentConcluido;
        }
        public int id { get; set; }
        public string name { get; set; }
        public string dataLimite { get; set; }
        public int percentConcluido { get; set; }
    }
}