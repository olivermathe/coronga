namespace aula02_exercicios_oo.domain
{
    public class Cliente : Pessoa
    {
        public Cliente(int codigo, string nome, double salario):
            base(codigo,nome)
        {
            this.salario = salario;
        }
        public double salario { get; set; }

    }
}