using Playground;
namespace CalculadoraTeste
{
    public class CalculadoraTeste 
    {
        private Calculadora _calc;
        public CalculadoraTeste()
        {
            _calc = new Calculadora();
        }

    [Fact]
        public void testaAdicaoComValor5e10Resultado()
        {
            // Arrange 

            int num1 = 10;
            int num2 = 5;


            // Act
            int resultado = _calc.Adicao(num1, num2);


            // Assert
            Assert.Equal(15, resultado);
        }

        [Fact]
        public void testaComValor7e10Resultado17()
        {
            // Arrange
            int num1 = 7;
            int num2 = 10;

            // Act
            int resultado = _calc.Adicao(num1, num2);

            //
            Assert.Equal(17, resultado);

        }

        [Fact]
        public void testaDivisaoDeveSerZero()
        {
            // Arrange
            int num1 = 4;
            int num2 = 0;

            //Act
            int resultado = _calc.Divisao(num1, num2);

            // Assert
            Assert.Equal(0, resultado);
        }

        [Fact]
        public void testaDivisaoDeveLancarExecao()
        {
            // Arrange
            int num1 = 5;
            int num2 = 0;

            //Act
            int resultado = _calc.Divisao(num1, num2);

            // Assert
            Assert.Throws<DivideByZeroException>(() =>
            {
                int resultado = _calc.Divisao(num1, num2);
            });
        }

        [Theory]
        [InlineData(10,10, 20)]
        [InlineData(15, 5, 20)]
        [InlineData(10, 5, 15)]

        public void testaAdicaoResultadoDeveSerValido(int numA, int numB, int expectativa)
        {
            // Act
            int resultado = _calc.Adicao(numA, numB);

            // Assert 
            Assert.Equal(expectativa, resultado);

        }

    }
}