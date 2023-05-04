using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools;
using TesteIMC;


namespace TestarIMC
{
    //metodo de testes que voce quer executar
    [TestClass]
    public class CalculoIMCTests
        
    {
        //metodo de teste
        [TestMethod]
        //descrição do teste

        public void CalcularIMC()
        {
            // arrange - organizar, preparar o teste
            double peso = 110;
            double altura = 1.79;

            // act - agir - execução / chamada do metodo
            var resultadoIMC = Operacoes.CalcularIMC(peso, altura);

            // assert - comportamento esperado, comportamento obtido
            Assert.AreEqual(34,33,resultadoIMC);
        }

    }
}
