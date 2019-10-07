namespace aula05.domain
{
    public class Cliente : Pessoa
    {
        public Cliente(string nome, int codCli, double salario): 
            base(nome, codCli)
        {
            this.salario = salario;
        }
        public double salario { get; set; }
    }
}