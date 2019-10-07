using System;
namespace aula05.domain
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciar clientes
            Cliente clienteAldrin = new Cliente("clienteAldrin", 1, 5000);
            Cliente clinteFulano = new Cliente("fulano", 2, 1000);

            CartaoCredito cartao01 = new CartaoCredito(1, new DateTime(2019,10/31), clienteAldrin);
            CartaoCredito cartao02 = new CartaoCredito(2, new DateTime(2019,12,12), clinteFulano);

            Console.WriteLine($"cartao1:{cartao01.numero} / {cartao01.dataValidade.ToString("MM-yyyy")} / {cartao01.cliente}");
            Console.WriteLine($"cartao2:{cartao02.numero} / {cartao02.dataValidade.ToString("MM-yyyy")}");
        }
    }
}
