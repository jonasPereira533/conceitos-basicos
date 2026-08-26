namespace TesteConceitoBasicos;

using exemplosCSharp.fixacao;

[TestClass]
public class TesteFatorial
{
    [TestMethod]
    public void TestMethod1()
    {
        //cenario
        int numero = 5;
        int resultadoEsperado = 120;


        //ação
        int resultado = CalcularFatorial.fatorial(numero);

        //verificação
        Assert.AreEqual(resultadoEsperado, resultado);
    }
}
