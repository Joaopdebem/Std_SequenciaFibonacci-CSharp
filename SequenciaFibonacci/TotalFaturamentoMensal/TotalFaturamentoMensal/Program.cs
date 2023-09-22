using System;
using System.Collections.Generic;
using System.Linq;

namespace FaturamentoDistribuidora
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<FaturamentoEstado> faturamentosEstados = new List<FaturamentoEstado>
            {
                new FaturamentoEstado("SP", 67836.43m),
                new FaturamentoEstado("RJ", 36678.66m),
                new FaturamentoEstado("MG", 29229.88m),
                new FaturamentoEstado("ES", 27165.48m),
                new FaturamentoEstado("Outros", 19849.53m)
            };

            decimal faturamentoTotal = faturamentosEstados.Sum(fe => fe.Valor);

            foreach(var faturamentoEstado in faturamentosEstados)
            {
                decimal percentual = (faturamentoEstado.Valor / faturamentoTotal) * 100;
                Console.WriteLine($"Estado: {faturamentoEstado.Estado} - Percentual: {percentual:F2}%");
            }
        }
    }
    public class FaturamentoEstado
    {
        public string Estado { get; set; }
        public decimal Valor { get; set; }

        public FaturamentoEstado(string estado, decimal valor)
        {
            Estado = estado;
            Valor = valor;
        }
    }
}
