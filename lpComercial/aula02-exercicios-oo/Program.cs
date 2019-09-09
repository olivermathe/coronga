using System;
using aula02_exercicios_oo.domain;

namespace aula02_exercicios_oo
{
    class Program
    {
        static void Main(string[] args)
        {
            //função principal tem que instanciar os bagulhos
            Cliente oCamila = new Cliente(1232, "Camila", 10000);
            Cliente oCassio = new Cliente(111, "Cassio", 5000);
            
            CartaoCredito cartao1 =  new CartaoCredito("1456987", new DateTime(2019,12,31),oCassio);
            CartaoCredito cartao2 =  new CartaoCredito("123456", new DateTime(2020,12,31),oCamila);

            
           Console.WriteLine($"cartao1:{cartao1.numero} / {cartao1.validadeCartao.ToString("MM-yyyy")}");
           Console.WriteLine($"cartao2:{cartao2.numero} / {cartao2.validadeCartao.ToString("MM-yyyy")}");
           
           Agencia agencia = new Agencia("1234");
           Agencia agencia2 = new Agencia("4321");

           Console.WriteLine($"Agencia 1: {agencia.numero}");
           Console.WriteLine($"Agencia 2: {agencia2.numero}");

           Gerente gerente1 = new Gerente("Elias", 10000.00);
           gerente1.atualizarSalario();
           Console.WriteLine($"Salario ficou: {gerente1.salario}");
        }
    }
}

