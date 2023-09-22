using System;
using System.Linq;
using System.Threading;

namespace SequenciaFibonacci
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número maior que zero!");
            int numeroInformado = int.Parse(Console.ReadLine());
            Console.WriteLine($"Vamos verificar se {numeroInformado} faz parte da sequência de Fibonacci.");

            int primeiroValor = 0;
            int segundoValor = 1;
            int[] sequenciaFibonacci = new int[numeroInformado];

            for (int i = 0; i < numeroInformado; i++)
            {
                sequenciaFibonacci[i] = primeiroValor;
                int proximoValor = primeiroValor + segundoValor;
                primeiroValor = segundoValor;
                segundoValor = proximoValor;

                if (i == 0 && primeiroValor == 0)
                {
                    primeiroValor = 1;
                }
            }
            Console.WriteLine("\nCalculando...\n");
            Thread.Sleep(1500);
            if (Array.IndexOf(sequenciaFibonacci, numeroInformado) >= 0)
            {
                Console.WriteLine($"Sim, {numeroInformado} faz parte da sequencia de fibonacci.");
                Console.WriteLine("Sequência de Fibonacci: " + string.Join(", ", sequenciaFibonacci) + "...");
            } else
            {
                Console.WriteLine($"Nãi, infelizmento {numeroInformado} não faz parte da sequencia de fibonacci.");
                Console.WriteLine("Sequência de Fibonacci: " + string.Join(", ", sequenciaFibonacci) + "...");
            }
        }
    }
}
