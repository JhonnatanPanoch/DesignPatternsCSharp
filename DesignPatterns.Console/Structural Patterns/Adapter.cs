namespace DesignPatterns.Cli.Structural_Patterns;

// Interface esperada pelo sistema
public interface IAlvo
{
    void Executar();
}

// Classe existente (incompatível)
public class Adaptado
{
    public void MetodoEspecifico()
    {
        Console.WriteLine("Executando método específico");
    }
}

// Adapter que faz a ponte
public class Adapter : IAlvo
{
    private readonly Adaptado _adaptado;

    public Adapter(Adaptado adaptado)
    {
        _adaptado = adaptado;
    }

    public void Executar()
    {
        _adaptado.MetodoEspecifico();
    }
}


/// <summary>
/// Permite que duas interfaces incompatíveis trabalhem juntas. Ele adapta uma classe existente para a interface esperada por outra.
/// </summary>
public static class AdapterPattern
{
    public static void Run()
    {
        IAlvo alvo = new Adapter(new Adaptado());
        alvo.Executar();
    }
}
