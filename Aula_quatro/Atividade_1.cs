using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Quatro_lpt
{
    internal class Atividade_1
    {
        public Atividade_1() 
        {
            Console.WriteLine("Digite o ano que vc nasceu: ");
            int anoNascimento = Convert.ToInt32(Console.ReadLine());
            int anoAtual = DateTime.Now.Year;
            int anoFinal = anoAtual - anoNascimento;
            Console.WriteLine("A sua idade é: " + anoFinal);
        }
     }
}
