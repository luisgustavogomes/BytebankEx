using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytebankEx
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Metodo();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Aconteceu um erro!");
            }
            finally
            {
                Console.ReadLine();
            }
        }

        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            try
            {
                int resultado = Dividir(10, divisor);
                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é possível fazer a divisão!");
            }
        }

        private static int Dividir(int numero, int divisor)
        {
            ContaCorrente conta = null;
            Console.WriteLine(conta.Saldo);
            return numero / divisor;
        }

        public static void Separador()
        {
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}
