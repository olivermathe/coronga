namespace aula02_exercicios_oo.domain
{
    public class Agencia
    {
        public Agencia(string numero)
        {
            this.numero = numero;
        }
        public string numero { get; private set; }
    }
}