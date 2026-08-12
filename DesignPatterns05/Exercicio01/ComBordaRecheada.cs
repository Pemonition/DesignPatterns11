namespace DesignPatterns05.Exercicio01;

public class ComBordaRecheada : IPizza
{
    private readonly IPizza _pizza;

    public ComBordaRecheada(IPizza pizza)
    {
        _pizza = pizza;
    }

    public string GetDescricao() => _pizza.GetDescricao() + " com Borda Recheada";

    public double GetPreco() => _pizza.GetPreco() + 8.00;
}