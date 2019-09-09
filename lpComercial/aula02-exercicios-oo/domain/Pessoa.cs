namespace aula02_exercicios_oo.domain
{
    public abstract class Pessoa
    {
        public Pessoa(int codigo, string nome)
        {
            this.codigo = codigo;
            this.nome = nome;
        }
        protected int codigo { get; set; }
        protected string nome { get; set; }
    }
}