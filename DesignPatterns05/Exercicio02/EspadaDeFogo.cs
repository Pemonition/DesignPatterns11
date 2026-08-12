namespace DesignPatterns05.Exercicio02;

public class EspadaDeFogo : IAtaque
{
    private readonly IAtaque _ataque;

    public EspadaDeFogo(IAtaque ataque)
    {
        _ataque = ataque;
    }

    public int CalcularDano() => _ataque.CalcularDano() + 15;
}

