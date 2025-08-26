using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Cli.Creational_Patterns;

public abstract class Documento
{
    public string Conteudo { get; set; }
    public abstract Documento Clonar();
}

public class Relatorio : Documento
{
    public override Documento Clonar() => (Documento)this.MemberwiseClone();
}


/// <summary>
/// Cria novos objetos copiando um protótipo existente.
/// Útil quando a criação de objetos é custosa e é melhor clonar um existente.
/// </summary>
public class Prototype
{
    public void Run()
    {
        // Uso
        var relatorio1 = new Relatorio { Conteudo = "Relatório Original" };
        var relatorio2 = relatorio1.Clonar();
        relatorio2.Conteudo = "Cópia do Relatório";

        Console.WriteLine(relatorio1.Conteudo); // Relatório Original
        Console.WriteLine(relatorio2.Conteudo); // Cópia do Relatório
    }
}
