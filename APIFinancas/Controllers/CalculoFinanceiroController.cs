using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace APIFinancas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculoFinanceiroController : ControllerBase
    {

        [HttpGet("juroscompostos")]
        public object Get(
            [FromServices]ILogger<CalculoFinanceiroController> logger,
            double valorEmprestimo, int numMeses, double percTaxa)
        {
            logger.LogInformation(
                "Recebida nova requisição|" +
               $"Valor do empréstimo: {valorEmprestimo}|" +
               $"Número de meses: {numMeses}|" +
               $"% Taxa de Juros: {percTaxa}");

            double valorFinalJuros =
                CalculoFinanceiro.CalcularValorComJurosCompostos(
                    valorEmprestimo, numMeses, percTaxa);
            logger.LogInformation($"Valor Final com Juros: {valorFinalJuros}");

            return new
            {
                ValorEmprestimo = valorEmprestimo,
                NumMeses = numMeses,
                TaxaPercentual = percTaxa,
                ValorFinalComJuros = valorFinalJuros
            };
        }
    }
}