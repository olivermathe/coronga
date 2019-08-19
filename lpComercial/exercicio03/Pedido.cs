using System;
class Pedido
{
    public int codPedido { get; set; }
    public DateTime dataPedido { get; set; }
    public string listaLivro { get; set; }
    public int quantLivros { get; set; }
    public double valor { get; set; }

    public void calcValor()
    {}
}