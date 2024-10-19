public class ProdutoFisico : Produto
{
    private double _peso; 
    private Dimensoes _dimensoes;

    public double Peso
    {
        get { return _peso; } 
        set
        {
            if (value <= 0)
                throw new ArgumentException("O peso deve ser maior que zero.");
            _peso = value; 
        }
    }

    public Dimensoes Dimensoes
    {
        get { return _dimensoes; } 
        set
        {
            if (value.Altura <= 0 || value.Largura <= 0 || value.Profundidade <= 0)
                throw new ArgumentException("As dimensões devem ser maiores que zero.");
            _dimensoes = value; 
        }
    }

    public string Categoria { get; set; }

    public ProdutoFisico(string nome, decimal preco, double peso, Dimensoes dimensoes, string categoria) : base(nome, preco)
    {
        Peso = peso; 
        Dimensoes = dimensoes; 
        Categoria = categoria;
    }

    public override decimal CalcularPrecoFinal()
    {
        decimal taxaDeImpostos = 0.1m;
        decimal impostos = Preco * taxaDeImpostos;

        double valorPorKg = 5;
        double custoDoEnvio = Peso * valorPorKg;

        decimal valorFinal = Preco + impostos + (decimal)custoDoEnvio;
        decimal descontos = valorFinal * 0.05m;
        valorFinal -= descontos;

        return valorFinal;
    }
}
public struct Dimensoes
{
    private double _altura; 
    private double _largura;
    private double _profundidade;
    public double Altura
    {
        get { return _altura; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("A altura deve ser maior que zero.");
            _altura = value;
        }
    }

    public double Largura
    {
        get { return _largura; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("A largura deve ser maior que zero.");
            _largura = value;
        }
    }

    public double Profundidade
    {
        get { return _profundidade; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("A profundidade deve ser maior que zero.");
            _profundidade = value;
        }
    }

    public Dimensoes(double altura, double largura, double profundidade)
    {
        if (altura <= 0 || largura <= 0 || profundidade <= 0)
            throw new ArgumentException("As dimensões devem ser maiores que zero.");

        _altura = altura;
        _largura = largura;
        _profundidade = profundidade;
    }
}
