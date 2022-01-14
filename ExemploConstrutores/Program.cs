using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        public delegate void Operacao(int x, int y);
        static void Main(string [] args)
        {
            //Delegate
            // Operacao op = new Operacao(Calculadora.Somar);
            // op += Calculadora.Subtrair;
            // op.Invoke(10, 10);

            // Constante
            // const double pi = 3.14;
            // System.Console.WriteLine(pi);

            // Get & Set
            // Data data = new Data();
            // //data.SetMes(2);

            // data.Mes = 12;
            // System.Console.WriteLine(data.Mes);
            // data.ApresentarMes();

            // Construtores de herança
            // Aluno p1 = new Aluno("Leonardo", "Buta", "Teste");
            // p1.Apresentar();

            // Construtor Privado
            // Log l1 = Log.GetInstance();

            // log.PropriedadeLog = "Teste instancia";

            // Log l2 = Log.GetInstance();
            // System.Console.WriteLine(l2.PropriedadeLog);

            // Construtores
            // Pessoa p1 = new Pessoa("Leonardo", "Buta");
            // p1.Apresentar();
        }
    }
}