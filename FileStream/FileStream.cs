using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CriarArquivo
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite o nome do arquivo:");
                string arq = Console.ReadLine();
                string data;
                FileStream fs = new FileStream($"c:\\Users\\Sala\\{arq}", FileMode.Open, FileAccess.Read);
                using (StreamReader sr = new StreamReader(fs))
                {
                    data = sr.ReadToEnd(); 
                }
                fs.Close();
                Console.WriteLine(data);
            }
            catch (Exception e)
            {
                Console.WriteLine($"O arquivo não existe!:" , e.Message);
            }
        }
    }
}