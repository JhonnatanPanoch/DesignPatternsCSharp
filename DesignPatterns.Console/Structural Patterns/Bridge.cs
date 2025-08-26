namespace DesignPatterns.Cli.Structural_Patterns;

// Implementador
public interface IDispositivo
{
    void Ligar();
    void Desligar();
}

// Implementações concretas
public class TV : IDispositivo
{
    public void Ligar() => Console.WriteLine("TV ligada");
    public void Desligar() => Console.WriteLine("TV desligada");
}

public class Radio : IDispositivo
{
    public void Ligar() => Console.WriteLine("Rádio ligado");
    public void Desligar() => Console.WriteLine("Rádio desligado");
}

// Abstração
public abstract class ControleRemoto
{
    protected IDispositivo dispositivo;

    protected ControleRemoto(IDispositivo dispositivo)
    {
        this.dispositivo = dispositivo;
    }

    public abstract void BotaoLigar();
}

// Abstração refinada
public class ControleBasico : ControleRemoto
{
    public ControleBasico(IDispositivo dispositivo) : base(dispositivo) { }

    public override void BotaoLigar()
    {
        dispositivo.Ligar();
    }
}

/// <summary>
/// Separa uma abstração da sua implementação, permitindo que as duas evoluam independentemente.
/// </summary>
public static class Bridge
{
    public static void Run()
    {
        // Uso
        ControleRemoto controle = new ControleBasico(new TV());
        controle.BotaoLigar();

        controle = new ControleBasico(new Radio());
        controle.BotaoLigar();
    }
}