using System;

namespace Calculadora
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Operacores operacoes = new();
            Validacao validacao = new();

            string continuar;
            do
            {
                double numero1 = validacao.LerEValidarNumero("Digite o 1º número");
                double numero2 = validacao.LerEValidarNumero("Digite o 2º número");

                if (numero1 != 0 && numero2 != 0)
                {
                    Console.WriteLine($"Os números digitados foram: {numero1} e {numero2}");
                }

                string entrada = validacao.LerEValidarString("Escolha a operação desejada: ");

                operacoes.OperacoesSwicth(entrada, numero1, numero2);
                continuar = validacao.LerEValidarString("Deseja fazer outra operação?");

            } while (continuar.ToUpper() == "S" || continuar.ToUpper() == "SIM");

            Console.WriteLine("\nObrigado por tudo");
            Console.WriteLine("Bye Bye ;)");

            Console.ReadKey();
        }
    }
}
