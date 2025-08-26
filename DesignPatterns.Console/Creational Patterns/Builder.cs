namespace DesignPatterns.Cli.Creational_Patterns;

// Produto
public class Carro
{
    public string Motor { get; set; }
    public string Rodas { get; set; }
    public string Cor { get; set; }

    public override string ToString() => $"Carro com Motor={Motor}, Rodas={Rodas}, Cor={Cor}";
}

// Builder
public interface ICarroBuilder
{
    void ConstruirMotor();
    void ConstruirRodas();
    void ConstruirCor();
    Carro ObterCarro();
}

// Builder Concreto
public class CarroEsportivoBuilder : ICarroBuilder
{
    private Carro _carro = new Carro();

    public void ConstruirMotor() => _carro.Motor = "V8";
    public void ConstruirRodas() => _carro.Rodas = "Aro 20";
    public void ConstruirCor() => _carro.Cor = "Vermelho";
    public Carro ObterCarro() => _carro;
}

// Diretor
public class Diretor
{
    public Carro Construir(ICarroBuilder builder)
    {
        builder.ConstruirMotor();
        builder.ConstruirRodas();
        builder.ConstruirCor();

        return builder.ObterCarro();
    }
}

/// <summary>
/// Constrói objetos complexos passo a passo, permitindo diferentes representações de um mesmo produto.
/// Separação da construção do objeto de sua representação final.
/// </summary>
public class Builder
{
    public void Run()
    {
        // Uso
        var diretor = new Diretor();
        var carroBuilder = new CarroEsportivoBuilder();
        var carro = diretor.Construir(carroBuilder);

        Console.WriteLine(carro);
    }
}
