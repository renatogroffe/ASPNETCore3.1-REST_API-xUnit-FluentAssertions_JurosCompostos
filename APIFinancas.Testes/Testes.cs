using FluentAssertions;
using Xunit;

namespace APIFinancas.Testes
{
    public class Testes
    {
        [Theory]
        [InlineData(10000, 12, 2, 12682.42)]
        [InlineData(11937.28, 24, 4, 30598.88)]
        [InlineData(15000, 36, 6, 122208.78)]
        [InlineData(20000, 36, 6, 162945.04)]
        [InlineData(25000, 48, 6, 409846.79)]
        public void TestarJurosCompostos(
            double valorEmprestimo, int numMeses, double percTaxa,
            double valorEsperado)
        {
            double valorCalculado = CalculoFinanceiro
                .CalcularValorComJurosCompostos(
                    valorEmprestimo, numMeses, percTaxa);
            valorCalculado.Should().Be(valorEsperado,
                "Falha no c�lculo de Juros Compostos: " +
               $"Valor do empr�stimo: {valorEmprestimo}|" +
               $"N�mero de meses: {numMeses}|" +
               $"% Taxa de Juros: {percTaxa}|" +
               $"Valor Esperado com Juros Compostos: {valorEsperado}|" +
               $"Valor Calculado com Juros Compostos: {valorCalculado}");
        }
    }
}