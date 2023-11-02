

namespace Calculadora
{
    class Operacores
    {
        public double Soma(double n1, double n2)
        {
            return n1 + n2;
        }
        public double Subtracao(double n1, double n2)
        {
            if (n2 > n1)
            {
                return n2 - n1;
            }
            return n1 - n2;
        }
        public double Divisao(double n1, double n2)
        {
            return n1 / n2;
        }
        public double Multiplicacao(double n1, double n2)
        {
            return n1 * n2;
        }
        public double Resto(double n1, double n2)
        {
            return n1 % n2;
        }
        public void OperacoesSwicth(string entrada, double n1, double n2)
        {
            switch (entrada)
            {
                case "+":
                    Console.WriteLine(Soma(n1, n2));
                    break;
                case "-":
                    Console.WriteLine(Subtracao(n1, n2));
                    break;
                case "/":
                    Console.WriteLine(Divisao(n1, n2));
                    break;
                case "*":
                    Console.WriteLine(Multiplicacao(n1, n2));
                    break;
                case "%":
                    Console.WriteLine(Resto(n1, n2));
                    break;
            }
        }
    }
}
