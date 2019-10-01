namespace TarefasArnaldo.Models
{
    public class Tarefas
    {
        public Tarefas(int id, string nome, string dataLimite, int percentConcluido)
        {
            this.id = id;
            this.nome = nome;
            this.dataLimite = dataLimite;
            this.percentConcluido = percentConcluido;
        }
        public int id { get; set; }
        public string nome { get; set; }
        public string dataLimite { get; set; }
        public int percentConcluido { get; set; }
    }
}