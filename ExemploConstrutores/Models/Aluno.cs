namespace ExemploConstrutores.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(string nome, string sobrenome, string diciplina) : base(nome, sobrenome)
        {
            System.Console.WriteLine("Construtor classe aluno");
        }
    }
}