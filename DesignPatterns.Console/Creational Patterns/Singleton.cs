namespace DesignPatterns.Cli.Creational_Patterns;

public sealed class Logger
{
    private static readonly Logger _instancia = new Logger();

    private Logger() { }

    public static Logger Instancia => _instancia;

    public void Log(string mensagem) => Console.WriteLine($"[LOG]: {mensagem}");
}



/// <summary>
/// Garante que exista apenas uma instância de uma classe, com acesso global.
/// Muito usado para logging, cache, gerenciadores de configuração, etc.
/// </summary>
public static class Singleton
{
    public static void Run()
    {
        // Uso
        Logger.Instancia.Log("Sistema iniciado");
    }
}