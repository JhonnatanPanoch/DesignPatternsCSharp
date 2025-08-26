namespace DesignPatterns.Cli.Creational_Patterns;

// Produto
public abstract class Transporte
{
    public abstract void Entregar();
}

// Implementações concretas
public class Caminhao : Transporte
{
    public override void Entregar() => Console.WriteLine("Entrega por caminhão");
}

public class Navio : Transporte
{
    public override void Entregar() => Console.WriteLine("Entrega por navio");
}

// Creator
public abstract class Logistica
{
    public abstract Transporte CriarTransporte();

    public void PlanejarEntrega()
    {
        var transporte = CriarTransporte();
        transporte.Entregar();
    }
}

// Concrete Creators
public class LogisticaRodoviaria : Logistica
{
    public override Transporte CriarTransporte() => new Caminhao();
}

public class LogisticaMaritima : Logistica
{
    public override Transporte CriarTransporte() => new Navio();
}

/// <summary>
/// Cria objetos através de um método, deixando para as subclasses a decisão de qual classe instanciar.
/// O método CriarTransporte() delega às subclasses a escolha do objeto.
/// </summary>
public static class FactoryMethod
{
    public static void Run()
    {
        // Uso
        var logistica = new LogisticaRodoviaria();
        logistica.PlanejarEntrega();
    }
}