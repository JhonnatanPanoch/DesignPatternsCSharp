namespace DesignPatterns.Cli.Structural_Patterns;

// Componente
public interface ICafe
{
    string Descricao();
    double Custo();
}

// Componente concreto
public class CafeSimples : ICafe
{
    public string Descricao() => "Café simples";
    public double Custo() => 2.0;
}

// Decorador base
public abstract class CafeDecorator : ICafe
{
    protected ICafe cafe;
    public CafeDecorator(ICafe cafe) => this.cafe = cafe;

    public virtual string Descricao() => cafe.Descricao();
    public virtual double Custo() => cafe.Custo();
}

// Decoradores concretos
public class ComLeite : CafeDecorator
{
    public ComLeite(ICafe cafe) : base(cafe) { }

    public override string Descricao() => base.Descricao() + ", com leite";
    public override double Custo() => base.Custo() + 1.0;
}

public class ComChocolate : CafeDecorator
{
    public ComChocolate(ICafe cafe) : base(cafe) { }

    public override string Descricao() => base.Descricao() + ", com chocolate";
    public override double Custo() => base.Custo() + 1.5;
}

/// <summary>
/// Adiciona comportamento extra a um objeto dinamicamente, sem alterar sua classe original.
/// </summary>
public static class Decorator
{
    public static void Run()
    {
        ICafe cafe = new CafeSimples();
        cafe = new ComLeite(cafe);
        cafe = new ComChocolate(cafe);

        Console.WriteLine($"{cafe.Descricao()} custa {cafe.Custo()}");
    }
}