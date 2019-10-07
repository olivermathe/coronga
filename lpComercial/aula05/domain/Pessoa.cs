namespace aula05.domain
{
    public class Pessoa
    {
        public Pessoa(string nome, int codCli)
        {
            this.nome = nome;
            this.codCli = codCli;

        }
        public string nome { get; set; }
        public int codCli { get; set; }
    }
}