using System;

public class Filme
{
    private Serie serie;
 
    public Filme(Serie serie)
    {
        this.serie = serie;
    }
 
    public void Reproduzir()
    {
        Console.WriteLine("Reproduzindo filme...");
        // lógica para reproduzir o filme
        this.serie.Reproduzir(); // chamada para reproduzir a série após o filme
    }
}
 
public class Serie
{
    private Filme filme;
 
    public Serie(Filme filme)
    {
        this.filme = filme;
    }
 
    public void Reproduzir()
    {
        Console.WriteLine("Reproduzindo série...");
        // lógica para reproduzir a série
        this.filme.Reproduzir(); // chamada para reproduzir o filme após a série
    }
}

class Program
{
    static void Main(string[] args)
    {
        Filme filme = new Filme(new Serie(null));
        Serie serie = new Serie(filme);

        // Reproduzindo um filme
        filme.Reproduzir();

        // Reproduzindo uma série
        serie.Reproduzir();
    }
}
