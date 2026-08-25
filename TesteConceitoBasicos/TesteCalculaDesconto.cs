using exemplosCSharp.fixacao;

namespace TesteConceitoBasicos;

[TestClass]
public class TesteCalculaDesconto
{
    [TestMethod]
    public void TestMethod1()
    {
        // cenario
        decimal valor = 100;
        decimal percentual = 10;
        decimal valorDesconto;

        // acao
        valorDesconto = CalcularDesconto.Desconto(valor, percentual);

        // validacao
        Assert.AreEqual(90, valorDesconto);
    }
}
