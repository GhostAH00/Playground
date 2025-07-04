using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PlaygroundTeste
{
    public class CPFTeste
    {

        private ValidadorCPF _cpf;

        public CPFTeste()
        {
            _cpf = new ValidadorCPF();
        }

        [Fact] // CPF-001
        public void ChamarValidarComUmCPFNumericamenteValido()
        {
            // Arrange 
            string cpf = "98765432100";

            // Act
            bool resultado = _cpf.Validar(cpf);

            // Assert
            Assert.True(resultado);
        }

        [Fact] // CPF-002
        public void ChamarValidarComUmCPFValidoEFormatado()
        {
            // Arrange
            string cpf = "123.456.789.-09";

            // Act
            bool resultado = _cpf.Validar(cpf);

            //Assert
            Assert.True(resultado);

        }

        [Fact] // CPF-003
        public void ChamarValidarComUmCPFComDigitosIguais()
        {
            // Arrange
            string cpf = "11111111111";

            // Act
            bool resultado = _cpf.Validar(cpf);

            // Assert
            Assert.False(resultado);
        }

        [Fact] // CPF-004
        public void ChamarValidarComUmCPFComDigitosInvalido()
        {
            // Arrange
            string cpf = "123456789000";

            // Act
            bool resultado = _cpf.Validar(cpf);

            // Assert
            Assert.False(resultado);

        }

        [Fact] // CPF-005
        public void ChamarValidarComUmaStringVazia()
        {
            //Arrange
            string cpf = "";

            // Act
            bool resultado = _cpf.Validar(cpf);

            // Assert
            Assert.False(resultado);
        }

        [Fact] // CPF-006
        public void ChamarValidarComNull()
        {
            // Arrannge
            string cpf = null;

            // Act
            bool resultado = _cpf.Validar(cpf);

            // Assert
            Assert.False(resultado);
        }

        [Fact] // CPF-007
        public void ChamarValidarComCpfDeTamanhoIncorreto()
        {
            // Arrannge
            string cpf = "123";

            // Act
            bool resultado = _cpf.Validar(cpf);

            // Assert
            Assert.False(resultado);
        }

        [Fact] // CPF-008
        public void ChamarValidarComCpfContendoLetras()
        {
            // Arrannge
            string cpf = "ABCDEFHIJK";

            // Act
            bool resultado = _cpf.Validar(cpf);

            // Assert
            Assert.False(resultado);

        }   

    }
}
