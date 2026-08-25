using exemplosCSharp.fixacao;

namespace TesteConceitoBasicos
{
    [TestClass]
    public sealed class TesteCalculaAumento
    {
        [TestMethod]
        public void TesteCalculaAumento0()
        {
            // cenario
            decimal salario = 1000;
            float percentual = 10;
            decimal valorAumento;

            CalculaAumento calc = new CalculaAumento();

            // ação
            valorAumento = calc.AumentarSalario(salario, percentual);

            // verificação
            Assert.AreEqual(valorAumento, 100);
        }

    }
}
