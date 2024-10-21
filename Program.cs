Console.Clear();
Loja minhaLoja = new Loja();


var produtoFisico = new ProdutoFisico("Camisa", 49.90m, 0.5, new Dimensoes(10, 20, 5), "Vestuário", 10);

minhaLoja.CadastrarProduto(produtoFisico);
Console.WriteLine($"Estoque do produto {produtoFisico.Nome}: {produtoFisico.Estoque} unidades!");
var produtoDigital = new ProdutoDigital("E-book de Programação", 29.90m, 5.0, "PDF");
minhaLoja.CadastrarProduto(produtoDigital);

Console.WriteLine("\n");
var contatoCliente1 = new Contato("5198022-6582", "Guilherme@gmail.com");
var cliente1 = new Cliente("Guilherme", "1", "Maquiné", contatoCliente1);
minhaLoja.CadastrarCliente(cliente1); 

Console.WriteLine("\n");
var pedido = minhaLoja.CriarPedido(cliente1); 
pedido.AdicionarProduto(produtoFisico); 
pedido.AdicionarProduto(produtoDigital); 
var total = pedido.CalcularTotal(); 
Console.WriteLine($"Total do pedido: {total:F2}"); 

minhaLoja.FinalizarPedido(pedido);

Console.WriteLine("Lista de produtos:");
minhaLoja.ListarProdutos();

Console.WriteLine("Lista de clientes:");
minhaLoja.ListarClientes();

Console.WriteLine("Lista de pedidos:");
minhaLoja.ListarPedidos();

