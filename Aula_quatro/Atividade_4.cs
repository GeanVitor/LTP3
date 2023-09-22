using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Quatro_lpt
{
    internal class Atividade_4
    {
        public Atividade_4() 
        {
            Console.WriteLine("Digite um numero: ");
            int nTabuada = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(nTabuada + "x" + i + "=" + nTabuada * i);
            }
        }
    }
}
