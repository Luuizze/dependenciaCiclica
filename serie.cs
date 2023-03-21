using System;
public class Serie
{
    private CatalogoMediador mediador;
 
    public Serie(CatalogoMediador mediador)
    {
        this.mediador = mediador;
    }
 
    public void Reproduzir()
    {
        this.mediador.ReproduzirSerie(this);
    }
}
