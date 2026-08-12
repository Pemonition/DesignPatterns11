namespace DesignPatterns05.Exercicio02;

public class PocaoFuria : IAtaque
{
    private readonly IAtaque _ataque;

    public PocaoFuria(IAtaque ataque)
    {
        _ataque = ataque;
    }

    public int CalcularDano() => _ataque.CalcularDano() * 2;
}