class Cliente
{   public string nome { get; set; }
    public int cod {get; set;}
    public string endereco {get; set;}
    public string cidade { get; set; }
    public int telefone { get; set; }
    public string pedidocli { get; set; }
    public int cep { get; set; }
    public string estado { get; set; }

    public void inserir(string nome)
    {
        this.nome=nome;
        //inserir dados do cliente
    }
    public void consultar()
    {
        //consultar pedido do cliente
    }
    public void alterar()
    {
        //alterar dados do cliente 
    }
    public void excluir()
    {
        //excluir cliente 
    }
    public void efetuarPedidoCliente()
    {
        //fazer pedido
    }
    public void efetuarPagamento()
    {
        //dados de pagamento
    }
}