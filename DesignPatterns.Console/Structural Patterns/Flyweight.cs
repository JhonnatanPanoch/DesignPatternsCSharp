namespace DesignPatterns.Cli.Structural_Patterns;

// Flyweight
public class Circulo
{
    public string Cor { get; set; }
    public int Raio { get; set; }
    public void Desenhar() => Console.WriteLine($"Círculo {Cor} com raio {Raio}");
}

// Flyweight Factory
public class CirculoFactory
{
    private readonly Dictionary<string, Circulo> _circulos = new();

    public Circulo GetCirculo(string cor)
    {
        if (!_circulos.ContainsKey(cor))
        {
            _circulos[cor] = new Circulo { Cor = cor };
        }
        return _circulos[cor];
    }
}

/// <summary>
/// Reduz o uso de memória compartilhando objetos comuns entre várias instâncias.
/// </summary>
public static class Flyweight
{
    public static void Run()
    {
        var factory = new CirculoFactory();

        var c1 = factory.GetCirculo("vermelho");
        c1.Raio = 5;
        c1.Desenhar();

        var c2 = factory.GetCirculo("vermelho"); // Reutilizado!
        c2.Raio = 10;
        c2.Desenhar();
    }
}
