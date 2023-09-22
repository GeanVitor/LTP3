using System;

namespace Simulado
{
    class AtividadeTres
    {
        public static void Calculadora()
        {
            Console.WriteLine(
                "----  Calculator Menu  ----\n"
                + "1. Addition\n"
                + "2. Subtraction\n"
                + "3. Multiplication\n"
                + "4. Division"
            );
            Console.Write("Escolha a operação: ");
            int operacao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite dois números: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                switch (operacao)
                {
                    case 1:
                        Console.WriteLine($">> {num1} + {num2} = {num1 + num2}");
                        break;
                    case 2:
                        Console.WriteLine($">> {num1} - {num2} = {num1 - num2}");
                        break;
                    case 3:
                        Console.WriteLine($">> {num1} * {num2} = {num1 * num2}");
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            throw new DivideByZeroException("Não é possível dividir por zero.");
                        }
                        Console.WriteLine($">> {num1} / {num2} = {num1 / num2}");
                        break;
                    default:
                        Console.WriteLine("Escolha inválida!");
                        break;
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}