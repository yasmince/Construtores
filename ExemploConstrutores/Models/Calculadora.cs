namespace ExemploConstrutores.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            System.Console.WriteLine($"Adição: {x + y}");
        }
        public void Subtracao(int x, int y)
        {
            System.Console.WriteLine($"Subtração: {x - y}");
        }
    }
}