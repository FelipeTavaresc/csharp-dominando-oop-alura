﻿namespace ScreenSound.Models;
internal class Album
{
    private static int ContadorDeObjetos;
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
        ContadorDeObjetos++;
        Nome = nome;
    }

    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public List<Musica> Musicas => musicas;

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
}