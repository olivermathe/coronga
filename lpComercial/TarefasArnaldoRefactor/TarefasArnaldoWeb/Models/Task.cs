namespace TarefasArnaldo.Models {
    public class Task {

        public Task(){
        }
        public Task (int id, string name, string date, string percentComplete) {
            this.id = id;
            this.name = name;
            this.date = date;
            this.percentComplete = percentComplete;
        }
        public int id { get; set; }
        public string name { get; set; }
        public string date { get; set; }
        public string percentComplete { get; set; }
    }
}