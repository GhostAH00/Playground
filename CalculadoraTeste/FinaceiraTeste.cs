using Playground;
namespace FinaceiraTeste
{
    public class FinaceiraTeste
    {
        private CalculadoraFinanceira _calcF;

        public FinaceiraTeste()
        {
          _calcF =  new CalculadoraFinanceira();
        }

        [Fact] // CF-001
        public void ChamarCalcularJurosSimplesComValoresPositivos()
        {
            // Arrange 
            int capitalInicial = 1000;
            int taxaJurosMensal = 1;
            int periodoMeses = 12;

            // Act
            int resultado = _calcF.CalcularJurosSimples(capitalInicial, taxaJurosMensal, periodoMeses);


            // Assert
            //Assert.

        }

        [Fact] // CF-002
        public void ChamarCalcularJurosSimplesComCapitalZero()
        {

        }

        [Fact] // CF-003
        public void ChamarCalcularJurosComCapitalNegativo()
        {

        }

        [Fact] // CF-004
        public void ChamarCalcularJurosCompostosComValoresPositivos()
        {

        }

        [Fact] // CF-005
        public void ChamarCalcularJurosCompostosComTaxaNegativa()
        {

        }

        [Fact] // CF-006
        public void ChamarAplicarDescontoComValorPositivo()
        {

        }

        [Fact] // CF-007
        public void ChamarAplicarDescontoCom100DeDesconto()
        {

        }

        [Fact] // CF-008
        public void ChamarAplicarDescontoComPercentualInvalido()
        {

        }

    }
}
