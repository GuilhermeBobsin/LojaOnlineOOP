public class Pedido : ICarreavel
{
    public Cliente Cliente { get; private set; }
    public DateTime DataPedido { get; private set; }
    public StatusPedido Status { get; private set; }
    private List<Produto> Produtos { get; set; }

    public Pedido(Cliente cliente)
    {
        Cliente = cliente ?? throw new ArgumentNullException(nameof(cliente));
        DataPedido = DateTime.Now;
        Status = StatusPedido.EmProcessamento;
        Produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        if (produto == null) 
        {
            throw new ArgumentException("O produto não pode ser nulo!");
        }
        Produtos.Add(produto);
        Console.WriteLine($"Produto {produto.Nome} adicionado ao carrinho!");
    }

    public void RemoverProduto(Produto produto)
    {
        if (Produtos.Contains(produto))
        {
            Produtos.Remove(produto);
            Console.WriteLine($"Produto {produto.Nome} removido do carrinho!");
        }
        else
        {
            Console.WriteLine($"Produto {produto.Nome} não encontrado no carrinho!");
        }
    }

    public decimal CalcularTotal()
    {
        decimal total = 0;
        foreach (var produto in Produtos)
        {
            total += produto.CalcularPrecoFinal();
        }
        return total;
    }

    public void FinalizarPedido()
    {
        if (Status == StatusPedido.Concluído)
        {
            Console.WriteLine("O pedido já foi concluído!");
            return;
        }

        Status = StatusPedido.Concluído;
        Console.WriteLine("Pedido finalizado com sucesso!");
    }




}









public enum StatusPedido
{
    EmProcessamento,
    Concluído,
    Cancelado
}