using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteIMC;

namespace TestarIMC
{
    [TestClass]
    public class ClassificaIMCTests
    {
        [TestMethod]

        public void ClassificarIMC()
        {
            //Arrange
            double imc = 29;
            //act
            var classificacaoIMC = Operacoes.ClassificarIMC(imc);
            // Assert
            Assert.AreEqual("Sobrepeso", classificacaoIMC);

        }
    }
}
