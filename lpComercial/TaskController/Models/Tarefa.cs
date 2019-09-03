namespace TarefaController.Models
{
    public class Tarefa
    {
        public Tarefa(){}
        public Tarefa(int prioridade, string tarefaNome, string dataLimite, int percentConcluido)
        {
            this.prioridade = prioridade;
            this.tarefaNome = tarefaNome;
            this.dataLimite = dataLimite;
            this.percentConcluido = percentConcluido;
        }
        public int prioridade { get; set; }
        public string tarefaNome { get; set; }
        public string dataLimite { get; set; }  
        public int percentConcluido { get ; set;}      
    }    
}