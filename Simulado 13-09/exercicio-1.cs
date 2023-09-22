using System;

namespace Simulado
{
    class AtividadeUm
    {
        public static void calculaImc()
        {
            int idade;
            int altura;
            double peso;

            try
            {
                Console.WriteLine("Por favor, insira sua idade:");
                idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Por favor, insira sua altura em centímetros:");
                altura = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite seu peso: ");
                peso = Convert.ToDouble(Console.ReadLine());

                if (idade >= 18 && altura >= 170)
                {
                    Console.WriteLine("Sua idade é maior que 18 e sua altura é maior que 170 cm!");

                    double alturaMetros = altura / 100.0;
                    double imc = peso / (alturaMetros * alturaMetros);

                    if (imc < 18.5)
                    {
                        Console.WriteLine("Seu IMC está abaixo do normal.");
                    }
                    else if (imc >= 18.5 && imc < 25)
                    {
                        Console.WriteLine("Seu IMC está Normal.");
                    }
                    else if (imc >= 25 && imc < 30)
                    {
                        Console.WriteLine("Seu IMC está indicando sobrepeso.");
                    }
                    else if (imc >= 30 && imc < 35)
                    {
                        Console.WriteLine("Você está com obesidade Grau I.");
                    }
                    else if (imc >= 35 && imc < 40)
                    {
                        Console.WriteLine("Você está com obesidade Grau II.");
                    }
                    else
                    {
                        Console.WriteLine("Você está com obesidade Grau III (mórbida ou mórbida severa).");
                    }
                }
                else
                {
                    Console.WriteLine("Sua idade não é maior que 18 e/ou sua altura não é maior que 170 cm.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Os valores inseridos não são numéricos!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
            }
        }
    }
}