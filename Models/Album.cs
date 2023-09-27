namespace ScreenSound.Models;
internal class Album : IAvaliavel
{
    private static int ContadorDeObjetos;
    private List<Musica> musicas = new List<Musica>();
    private List<Avaliacao> notas = new();

    public Album(string nome)
    {
        ContadorDeObjetos++;
        Nome = nome;
    }

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public List<Musica> Musicas => musicas;

    public double Media 
    {
        get{
            if(notas.Count > 0)
                return notas.Average(a => a.Nota);
            else
                return 0;
        }
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotal}");
    }

    public static void QuantidadeAlbumsCriados()
    {
        Console.WriteLine($"Total de objetos criados: { Album.ContadorDeObjetos}");
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }
}