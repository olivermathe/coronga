class Fornecedor
{
    public int codForn {get; set;}
    public string nomeForn { get; set; }
    public string enderecoForn {get; set;}
    public string cidadeForn { get; set; }
     public string estadoForn { get; set; }
     public int cepForn { get; set; }
    public int telefoneForn { get; set; }
    public string pedidoForn { get; set; }
    public int cnpj { get; set; }
   
    public void inserir()
    {
        //inserir dados fornecedor
    }
    public void excluir()
    {
        //excluir dados ou pedido do fornecedor
    }
    public void consultar()
    {
        //consultar pedido ou fornecedor
    }
    public void alterar()
    {
        //alterar pedido ou dados do fornecedor
    }
}