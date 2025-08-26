namespace DesignPatterns.Cli.Structural_Patterns;
// Interface
public interface IImagem
{
    void Exibir();
}

// Objeto real
public class ImagemReal : IImagem
{
    private string _arquivo;

    public ImagemReal(string arquivo)
    {
        _arquivo = arquivo;
        CarregarDoDisco();
    }

    private void CarregarDoDisco()
    {
        Console.WriteLine($"Carregando {_arquivo} do disco...");
    }

    public void Exibir()
    {
        Console.WriteLine($"Exibindo {_arquivo}");
    }
}

// Proxy
public class ImagemProxy : IImagem
{
    private ImagemReal _imagemReal;
    private string _arquivo;

    public ImagemProxy(string arquivo)
    {
        _arquivo = arquivo;
    }

    public void Exibir()
    {
        if (_imagemReal == null)
        {
            _imagemReal = new ImagemReal(_arquivo);
        }
        _imagemReal.Exibir();
    }
}

/// <summary>
/// Fornece um substituto ou representante para controlar o acesso a um objeto real.
/// </summary>
public static class Proxy
{
    public static void Run()
    {
        IImagem imagem = new ImagemProxy("foto.png");

        // Somente carrega quando for usar
        imagem.Exibir();
        imagem.Exibir(); // Reaproveita sem carregar novamente
    }
}

