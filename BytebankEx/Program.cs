using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytebankEx
{
    public class Program
    {

        public static void Main(string[] args)
        {

            CarregarContas();
            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            LeitorDeArquivo leitorDeArquivo = null;
            try
            {
                leitorDeArquivo = new LeitorDeArquivo("contasl.txt");
                leitorDeArquivo.LerProximaLinha();
            }
            catch (IOException e)
            {
                Console.WriteLine("Exceção: " + e.ToString());
            }
            finally
            {
                if (leitorDeArquivo != null)
                {
                    leitorDeArquivo.Fechar();
                }
            }
        }

        private static void Separador()
        {
            Console.WriteLine("----------------------------------------------------------");
        }

        public static string FormatDouble(double valor)
        {
            return "R$ " + String.Format("{0:N}", valor);
        }

        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(234, 234567);
                ContaCorrente contaDestino = new ContaCorrente(234, 234568);

                conta.Sacar(10000);

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
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine("Exceção: " + e.ToString());
            }
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