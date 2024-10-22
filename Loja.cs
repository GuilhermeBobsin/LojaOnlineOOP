public class Loja
{
    public List<Produto> Produtos { get; private set; }
    public List<Cliente> Clientes { get; private set; }
    public List<Pedido> Pedidos { get; private set; }

    public Loja()
    {
        Produtos = new List<Produto>();
        Clientes = new List<Cliente>();
        Pedidos = new List<Pedido>();
    }

    public void CadastrarProduto(Produto produto)
    {
        if (produto == null)
        {
            Console.WriteLine("Produto inválido!");
            return;
        }

        if (Produtos.Exists(p => p.Codigo == produto.Codigo))
        {
            Console.WriteLine("Produto já cadastrado!");
            return;
        }

        Produtos.Add(produto);
        Console.WriteLine($"Produto {produto.Nome} cadastrado com sucesso!");
    }

    public Produto ConsultarProdutoPorCodigo(string codigo)
    {
        return Produtos.Find(p => p.Codigo == codigo);
    }

    public void ListarProdutos()
    {
        if (Produtos.Count == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado!");
            return;
        }

        foreach (var produto in Produtos)
        {
            Console.WriteLine($"Código: {produto.Codigo}");
            Console.WriteLine($"Nome: {produto.Nome}");
            Console.WriteLine($"Preço: {produto.Preco}");
            if (produto is ProdutoFisico produtoFisico)
            {
                Console.WriteLine($"Quantidade em estoque: {produtoFisico.Estoque}");
            }
            else
            {
                Console.WriteLine("Quantidade em estoque: Ilimitado");
            }
            Console.WriteLine("\n");
        }
    }

    public void CadastrarCliente(Cliente cliente)
    {
        if (cliente == null)
        {
            Console.WriteLine("Cliente inválido!");
            return;
        }

        if (Clientes.Exists(c => c.NumeroIdentificacao == cliente.NumeroIdentificacao))
        {
            Console.WriteLine("Cliente já cadastrado!");
            return;
        }

        Clientes.Add(cliente);
        Console.WriteLine("Cliente cadastrado com sucesso!");
    }

    public Cliente ConsultarClientePorId(string numeroIdentificacao)
    {
        return Clientes.Find(c => c.NumeroIdentificacao == numeroIdentificacao);
    }

    public void ListarClientes()
    {
        if (Clientes.Count == 0)
        {
            Console.WriteLine("Nenhum cliente cadastrado!");
            return;
        }

        foreach (var cliente in Clientes)
        {
            Console.WriteLine($"Nome: {cliente.Nome}");
            Console.WriteLine($"Número de Identificação: {cliente.NumeroIdentificacao}");
            Console.WriteLine("\n");
        }
    }

    public Pedido CriarPedido(Cliente cliente)
    {
        if (cliente == null || !Clientes.Contains(cliente))
        {
            Console.WriteLine("Cliente não encontrado!");
            return null;
        }

        var pedido = new Pedido(cliente);
        Pedidos.Add(pedido);
        return pedido;
    }

    public void FinalizarPedido(Pedido pedido)
    {
        if (pedido == null || !Pedidos.Contains(pedido))
        {
            Console.WriteLine("Pedido não encontrado!");
            return;
        }

        foreach (var produto in pedido.Produtos)
        {
            if (produto is ProdutoFisico fisico)
            {
                if (fisico.Estoque <= 0)
                {
                    Console.WriteLine($"Produto {fisico.Nome} não disponível!");
                    return; 
                }
            }
        }

        foreach (var produto in pedido.Produtos)
        {
            if (produto is ProdutoFisico fisico)
            {
                fisico.RemoverEstoque(1); 
            }
        }

        pedido.FinalizarPedido(); 
        Console.WriteLine("Pedido concluído com sucesso!"); 
    }

    public void ListarPedidos()
    {
        if (Pedidos.Count == 0)
        {
            Console.WriteLine("Nenhum pedido realizado!");
            return;
        }

        foreach (var pedido in Pedidos)
        {
            Console.WriteLine($"Cliente: {pedido.Cliente.Nome}");
            Console.WriteLine($"Data do pedido: {pedido.DataPedido}");
            Console.WriteLine($"Status: {pedido.Status}");
        }
    }
}