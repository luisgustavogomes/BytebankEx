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
                ContaCorrente conta = new ContaCorrente(234, 234567);
                ContaCorrente contaDestino = new ContaCorrente(234, 234568);

                conta.Depositar(50);
                conta.Transferir(contaDestino, 500);

                Separador();
                Console.WriteLine(FormatDouble(conta.Saldo));
                Console.WriteLine(FormatDouble(contaDestino.Saldo));
            }
            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine("Exceção: " + e.ToString());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Exceção: " + e.ToString());
            }
            Console.ReadLine();
        }

        public static void Separador()
        {
            Console.WriteLine("----------------------------------------------------------");
        }

        public static string FormatDouble(double valor)
        {
            return "R$ " + String.Format("{0:N}", valor);
        }
    }
}


//    Alura
//    try
//    {
//        Metodo();
//    }
//    catch (NullReferenceException e)
//    {
//        Console.WriteLine("\nErro: " + e.ToString());
//    }
//    catch (DivideByZeroException e)
//    {
//        Console.WriteLine("Não é possível fazer a divisão!" + "\nErro: " + e.ToString());
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine("\nErro: " + e.ToString());
//    }

//    Console.ReadLine();
//}

//private static void Metodo()
//{
//    TestaDivisao(0);
//}

//private static void TestaDivisao(int divisor)
//{
//    int resultado = Dividir(10, divisor);
//    Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
//}

//private static int Dividir(int numero, int divisor)
//{
//    try
//    {
//        return numero / divisor;
//    }
//    catch (DivideByZeroException)
//    {
//        throw;
//    }
//}