public class ProdutoDigital : Produto
{
    private double _tamanhoArquivo;
    public double TamanhoArquivo
    {
        get { return _tamanhoArquivo; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("O tamanho do arquivo deve ser maior que zero.");
            _tamanhoArquivo = value;
        }
    }
    public string Formato { get; set; }

    public ProdutoDigital(string nome, decimal preco, double tamanhoArquivo, string formato) : base(nome, preco)
    {
        TamanhoArquivo = tamanhoArquivo;
        Formato = formato;
    }

    public override decimal CalcularPrecoFinal()
    {
        decimal taxaDesconto = 0.1m; 
        decimal valorDesconto = Preco * taxaDesconto;
        decimal precoFinal = Preco - valorDesconto;
        return precoFinal;
    }

}