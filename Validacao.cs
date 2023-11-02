using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Validacao
    {
        public double LerEValidarNumero(string mensagem)
        {
            double numero;
            Console.WriteLine(mensagem);
            string? input = Console.ReadLine();

            if (double.TryParse(input, out numero))
            {
            }
            else
            {
                Console.WriteLine("O valor digitado é inválido");
            }

            return numero;
        }
        public string LerEValidarString(string mensagem)
        {
            string? input;

            do
            {
                Console.WriteLine(mensagem);
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Entrada inválida. Por favor, forneça um valor válido.");
                }
            } while (string.IsNullOrWhiteSpace(input));

            return input;
        }
    }
}