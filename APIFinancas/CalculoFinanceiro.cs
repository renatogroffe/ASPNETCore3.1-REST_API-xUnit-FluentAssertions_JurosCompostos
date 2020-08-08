
using System;
 
namespace APIFinancas
{
    public static class CalculoFinanceiro
    {
        public static double CalcularValorComJurosCompostos(
            double valorEmprestimo, int numMeses, double percTaxa)
        {
            if (valorEmprestimo <= 0)
                throw new ArgumentException("O Valor do Empréstimo deve ser maior do que zero!");

            if (numMeses <= 0)
                throw new ArgumentException("O Número de Meses deve ser maior do que zero!");

            if (percTaxa <= 0)
                throw new ArgumentException("O Percentual da Taxa de Juros deve ser maior do que zero!");

            return valorEmprestimo * Math.Pow(1 + (percTaxa / 100), numMeses); // Simulação de falha 
            //return Math.Round(
            //    valorEmprestimo * Math.Pow(1 + (percTaxa / 100), numMeses), 2);
        }
    }
}