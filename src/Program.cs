using System;

namespace PasswordGenerator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Clear();

            var generator = new Generator();

            Console.WriteLine(" GERADOR DE SENHAS");
            Console.WriteLine("================================");

            Console.WriteLine("Senha com 120 caractéres: ");
            Console.WriteLine(generator.Generate(120), "\n");

            Console.WriteLine("\nSenha com 56 caractéres: ");
            Console.WriteLine(generator.Generate(56), "\n");

            Console.WriteLine("\nSenha com 24 caractéres: ");
            Console.WriteLine(generator.Generate(24));

            Console.WriteLine("\nSenha com 8 caractéres: ");
            Console.WriteLine(generator.Generate(8));

            Console.WriteLine("\nSenha com 0 carácter: ");
            Console.WriteLine(generator.Generate(0));

            Console.ReadKey();
        }
    }
}