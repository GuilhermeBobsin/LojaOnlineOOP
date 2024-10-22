public class Cliente
{
    private string _nome;
    private string _numeroIdentificacao;
    private string _endereco;
    public Contato Contato { get; set; }

    public string Nome
    {
        get { return _nome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("O nome não pode ser vazio");
            _nome = value;
        }
    }

    public string NumeroIdentificacao
    {
        get { return _numeroIdentificacao; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("O número de identificação não pode ser vazio");
            _numeroIdentificacao = value;
        }
    }

    public string Endereco
    {
        get { return _endereco; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("O endereço não pode ser vazio");
            _endereco = value;
        }
    }

    public Cliente(string nome, string numeroIdentificacao, string endereco, Contato contato)
    {
        Nome = nome;
        NumeroIdentificacao = numeroIdentificacao;
        Endereco = endereco;
        Contato = contato;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome do cliente: {Nome}");
        Console.WriteLine($"Número de identificação: {NumeroIdentificacao}");
        Console.WriteLine($"Endereço: {Endereco}");
        Console.WriteLine($"Contato: {Contato.Telefone} \n Email: {Contato.Email}");
    }
}

public struct Contato
{
    public string Telefone { get; set; }
    public string Email { get; set; }

    public Contato(string telefone, string email)
    {
        Telefone = telefone;
        Email = email;
    }
}