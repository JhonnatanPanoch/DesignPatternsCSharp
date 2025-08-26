using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cli.Structural_Patterns;

// Subsistemas
public class SistemaPedido
{
    public void CriarPedido() => Console.WriteLine("Pedido criado");
}

public class SistemaPagamento
{
    public void ProcessarPagamento() => Console.WriteLine("Pagamento processado");
}

public class SistemaEntrega
{
    public void EnviarProduto() => Console.WriteLine("Produto enviado");
}

// Facade
public class LojaFacade
{
    private readonly SistemaPedido _pedido = new();
    private readonly SistemaPagamento _pagamento = new();
    private readonly SistemaEntrega _entrega = new();

    public void Comprar()
    {
        _pedido.CriarPedido();
        _pagamento.ProcessarPagamento();
        _entrega.EnviarProduto();
    }
}

/// <summary>
/// Fornece uma interface simplificada para um conjunto complexo de subsistemas.
/// </summary>
public static class Facade
{
    public static void Run()
    {
        var loja = new LojaFacade();
        loja.Comprar();
    }
}