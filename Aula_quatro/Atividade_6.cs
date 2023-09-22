using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Quatro_lpt
{
    internal class Atividade_6
    {
        public Atividade_6() 
        {
            Console.WriteLine("Digite um numero: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 == number2)
            {
                int result = (number1 + number2) * 3;
                Console.WriteLine("O triplo é:" + result);
            }
            else
            {
                int result = number1 + number2;
                Console.WriteLine("A soma é: " + result);
            }
        }
    }
}
