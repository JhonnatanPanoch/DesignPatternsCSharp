namespace DesignPatterns.Cli.Creational_Patterns;

// Produtos abstratos
public interface ICadeira { void Sentar(); }
public interface ISofa { void Deitar(); }

// Produtos concretos
public class CadeiraVitoriana : ICadeira
{
    public void Sentar() => Console.WriteLine("Sentando em uma cadeira vitoriana");
}

public class SofaVitoriano : ISofa
{
    public void Deitar() => Console.WriteLine("Deitando em um sofá vitoriano");
}

// Outra família
public class CadeiraModerna : ICadeira
{
    public void Sentar() => Console.WriteLine("Sentando em uma cadeira moderna");
}

public class SofaModerno : ISofa
{
    public void Deitar() => Console.WriteLine("Deitando em um sofá moderno");
}

// Fábrica abstrata
public interface IMovelFactory
{
    ICadeira CriarCadeira();
    ISofa CriarSofa();
}

// Fábricas concretas
public class MovelVitorianoFactory : IMovelFactory
{
    public ICadeira CriarCadeira() => new CadeiraVitoriana();
    public ISofa CriarSofa() => new SofaVitoriano();
}

public class MovelModernoFactory : IMovelFactory
{
    public ICadeira CriarCadeira() => new CadeiraModerna();
    public ISofa CriarSofa() => new SofaModerno();
}

/// <summary>
/// Fornece uma fábrica de fábricas, criando famílias de objetos relacionados sem especificar suas classes concretas.
/// Permite trocar famílias de objetos sem alterar o código cliente.
/// </summary>
public static class AbstractFactory
{

    public static void Run()
    {
        // Uso
        var fabrica = new MovelVitorianoFactory();
        var cadeira = fabrica.CriarCadeira();
        cadeira.Sentar();
    }
}