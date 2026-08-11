namespace DesignPatterns05.Exercicio01;

public class PizzaMassaFina : IPizza
{
    public string GetDescricao()
    {
        return "Pizza Massa Fina";
    }

    public double GetPreco()
    {
        return 30.00;
    }
}