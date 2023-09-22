using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Quatro_lpt
{
    internal class Atividade_5
    {
        public Atividade_5() 
        {
            Console.WriteLine("Digite um numero: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("O numero é par!");
            }
            else
            {
                Console.WriteLine("O numero é impar!");
            }
        }
    }
}
