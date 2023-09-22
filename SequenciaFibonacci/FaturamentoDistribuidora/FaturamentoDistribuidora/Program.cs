using System;
using System.Linq;

namespace FaturamentoDistribuidora
{
    public class Program
    {
        private const int DiasNoAno = 365;
        private const int DiasUteisDeFaturamento = 5;
        private const int ValorMinimoGeradoFaturamento = 30000;
        private const int ValorMaximoGeradoFaturamento = 100001;

        static void Main(string[] args)
        {
            decimal[] faturamentoDiario = new decimal[DiasNoAno];
            Random faturamentoGerado = new Random();
            int contador = 0;

            for (int i = 0; i < faturamentoDiario.Length; i++)
            {
                if (contador == DiasUteisDeFaturamento)
                {
                    faturamentoDiario[i] = 0;
                    faturamentoDiario[i + 1] = 0;
                    contador = 0;
                    i++;
                }
                else
                {
                    faturamentoDiario[i] = faturamentoGerado.Next(ValorMinimoGeradoFaturamento, ValorMaximoGeradoFaturamento);
                    contador++;
                }
            }

            decimal[] diasSemFaturamento = faturamentoDiario.Where(f => f > 0).ToArray(); 
            decimal menorFaturamento = diasSemFaturamento.Min();

            decimal maiorFaturamento = faturamentoDiario.Max();

            decimal mediaAnual = faturamentoDiario.Sum(d => d > 0 ? d : 0) / DiasNoAno;

            int diasAcimaDaMedia = faturamentoDiario.Where(d => d > mediaAnual).Count();

            Console.WriteLine($"Menor faturamento diário: {menorFaturamento:C}");
            Console.WriteLine($"Maior faturamento diário: {maiorFaturamento:C}");
            Console.WriteLine($"Dias com faturamento acima da média anual: {diasAcimaDaMedia}");
        }
    }
}
