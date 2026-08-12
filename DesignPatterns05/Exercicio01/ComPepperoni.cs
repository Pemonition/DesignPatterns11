namespace DesignPatterns05.Exercicio01;

public class ComPepperoni
{
    private readonly IPizza _pizza;

    public ComPepperoni(IPizza pizza)
    {
        _pizza = pizza;
    }

    public string GetDescricao() => _pizza.GetDescricao() + " com Pepperoni";

    public double GetPreco() => _pizza.GetPreco() + 6.00;
}