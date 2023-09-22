using System;

namespace Aula_cinco
{
    class Atividade_1
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Digite seu nome: ");
          string nome = Console.ReadLine();
          Console.WriteLine("Digite sua idade: ");
          int idade = Int32.Parse(Console.ReadLine());
          Console.WriteLine($"O nome em Maiusculo e {nome.ToUpper()}");
          Console.WriteLine($"O nome em minsculo e {nome.ToLower()}");
          Console.WriteLine($"O nome sem espaços {nome.Trim()}");
          int anoUser = 2023 - idade;
          Console.WriteLine($"O ano de nascimento e {anoUser}");
          Console.WriteLine($"O usuario tera 100 anos em {anoUser + 100}");
        }
    }
}