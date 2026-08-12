namespace DesignPatterns05.Exercicio01;

public class ComQueijoExtra : IPizza
{
    private readonly IPizza _pizza;

    public ComQueijoExtra(IPizza pizza)
    {
        _pizza = pizza;
    }

    public string GetDescricao() => _pizza.GetDescricao() + " com Queijo Extra";

    public double GetPreco() => _pizza.GetPreco() + 5.00;
}