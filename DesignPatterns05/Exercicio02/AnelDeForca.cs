namespace DesignPatterns05.Exercicio02;

public class AnelDeForca : IAtaque
{
    private readonly IAtaque _ataque;

    public AnelDeForca(IAtaque ataque)
    {
        _ataque = ataque;
    }

    public int CalcularDano() => _ataque.CalcularDano() + 5;
}