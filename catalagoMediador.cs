public class CatalogoMediador
{
    private Filme filme;
    private Serie serie;
 
    public CatalogoMediador()
    {
        this.filme = new Filme(this);
        this.serie = new Serie(this);
    }
 
    public void ReproduzirFilme(Filme filme)
    {
        // lógica para reproduzir o filme
    }
 
    public void ReproduzirSerie(Serie serie)
    {
        // lógica para reproduzir a série
    }
}
