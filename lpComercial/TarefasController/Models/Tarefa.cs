namespace TarefasController.Models
{
    public class Tarefa
    {
        public Tarefa(){}
        public Tarefa(int id, string tarefaNome, string dataLimite, int percentConcluido)
        {
            this.id = id;
            this.tarefaNome = tarefaNome;
            this.dataLimite = dataLimite;
            this.percentConcluido = percentConcluido;
        }
        public int id { get; set; }
        public string tarefaNome { get; set; }
        public string dataLimite { get; set; }  
        public int percentConcluido { get ; set;}      
    }    
}