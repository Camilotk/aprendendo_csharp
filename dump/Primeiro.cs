using System;

namespace myProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar var
            string name = "Camilo";
            // Ler int do teclado
            Console.Write("Digite sua idade: ");
            int idade = Convert.ToInt16(Console.ReadLine());
            // Interpolação de var por ordem de parâmetro.
            Console.WriteLine("Olá {0}, seja bem-vindo ao C#!", name);
            // Interpolação por nome da var.
            Console.WriteLine($"Você tem {idade}");
            // Print arguments.
            Console.WriteLine($"0: {args[0]} 1: {args[1]}");
            
            // Ex.
            Console.WriteLine($"Você terá {idade + 5} em {System.DateTime.Now.Year + 5}!");
        }
    }
}
