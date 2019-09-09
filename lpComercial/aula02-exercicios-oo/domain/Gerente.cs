namespace aula02_exercicios_oo.domain
{
    public class Gerente
    {
        public Gerente(string nome, double salario)
        {
            this.nome = nome;
            this.salario = salario;
        }
        public string nome { get; private set; }
        public double salario { get; private set; }

        public void atualizarSalario(){
            this.salario+= salario*0.10;
        }
        public void atualizarSalario( double taxa)=> this.salario+=salario*taxa;
    }

}