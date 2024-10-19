public abstract class Produto
{
    public string Nome { get; set; }
    public string Codigo { get; private set; }
    public decimal Preco { get; set; }

    public Produto(string nome, decimal preco)
    {
        Nome = nome;
        Codigo = Guid.NewGuid().ToString();
        Preco = preco;
    }

    public abstract decimal CalcularPrecoFinal();
}