using System;
public class Filme
{
    private CatalogoMediador mediador;
 
    public Filme(CatalogoMediador mediador)
    {
        this.mediador = mediador;
    }
 
    public void Reproduzir()
    {
        this.mediador.ReproduzirFilme(this);
    }
}
