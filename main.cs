using System;
class Program
{
    static void Main(string[] args)
    {
        CatalogoMediador mediador = new CatalogoMediador();
        Filme filme = new Filme(mediador);
        Serie serie = new Serie(mediador);

        // Reproduzindo um filme
        filme.Reproduzir();

        // Reproduzindo uma série
        serie.Reproduzir();
    }
}
