using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Quatro_lpt
{
    internal class Atividade_2
    {
        public Atividade_2() 
        {
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome:");
            string sobrenome = Console.ReadLine();
            Console.WriteLine("Seu nome é: \n" + nome + "" + sobrenome);
        }
    }
}
