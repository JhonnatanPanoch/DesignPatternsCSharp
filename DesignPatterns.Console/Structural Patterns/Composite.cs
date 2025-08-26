using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cli.Structural_Patterns;

// Componente
public abstract class Arquivo
{
    public abstract void Mostrar();
}

// Folha
public class ArquivoTexto : Arquivo
{
    private readonly string _nome;

    public ArquivoTexto(string nome)
    {
        _nome = nome;
    }

    public override void Mostrar()
    {
        Console.WriteLine($"Arquivo texto: {_nome}");
    }
}

// Composite
public class Pasta : Arquivo
{
    private readonly List<Arquivo> _arquivos = new();

    public void Adicionar(Arquivo arquivo) => _arquivos.Add(arquivo);

    public override void Mostrar()
    {
        foreach (var arquivo in _arquivos)
            arquivo.Mostrar();
    }
}

/// <summary>
/// Cria uma estrutura em árvore onde objetos individuais e composições de objetos são tratados da mesma forma.
/// </summary>
public static class Composite
{
    public static void Run()
    {
        var pasta = new Pasta();
        pasta.Adicionar(new ArquivoTexto("documento.txt"));
        pasta.Adicionar(new ArquivoTexto("leia-me.md"));

        pasta.Mostrar();
    }
}