using System.ComponentModel.DataAnnotations;
using DesignPatterns05.exemplo02;
using DesignPatterns05.Exercicio01;
using DesignPatterns05.Exercicio02;
namespace DesignPatterns05;


class Program
{
    static void Main(string[] args)
    {
        IPagamentoService pagamentoService = new GatewayPagamentoService();

           Console.WriteLine("Processando checkout do café ☕️");
           try
           { 
               pagamentoService.ProcessarPagamento(10.00m);
           }
           catch (Exception e)
           {
               pagamentoService = new RetryPagamentoDecorator(pagamentoService, 3);
               pagamentoService.ProcessarPagamento(10.00m);
           }
           
           // Exercício 1 - Customizador de Pizza
           IPizza pizza = new PizzaMassaFina();
           pizza = new ComQueijoExtra(pizza);
           pizza = new ComBordaRecheada(pizza);
           pizza = new ComPepperoni(pizza);

           Console.WriteLine($"Descrição: {pizza.GetDescricao()}");
           Console.WriteLine($"Preço total: R$ {pizza.GetPreco():F2}");
           
           
           
           // Exercício 2 - Equipamentos e Buffs de RPG
           IAtaque ataque = new AtaqueBasico();
           Console.WriteLine($"Dano apenas com ataque básico: {ataque.CalcularDano()}");

           ataque = new EspadaDeFogo(ataque);
           ataque = new AnelDeForca(ataque);
           Console.WriteLine($"Dano com espada e anel equipados: {ataque.CalcularDano()}");

           ataque = new PocaoFuria(ataque);
           Console.WriteLine($"Dano com poção ativada sobre os itens: {ataque.CalcularDano()}");
       
           

        
    }
}