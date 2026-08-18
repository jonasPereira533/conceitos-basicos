using exemplosCSharp.fixacao;


/*    PRIMEIRO EXERCICIO 
Console.WriteLine("Informe o salario atual: ");
int salario = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o percentual de aumento: ");
int aumento = int.Parse(Console.ReadLine());

Console.WriteLine($"seu salario atual é: {salario}");
Console.WriteLine($"Com o aumento seu salario será: {Calculadora.Somar(salario, aumento)}");
*/


Console.WriteLine("Informe o preço do produto: ");
double preco = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o percentual de desconto: ");
double desconto = double.Parse(Console.ReadLine());

Console.WriteLine
    ($"O preço do produto com desconto é: {CalcularDesconto.Desconto(preco, desconto)}" + "\n" +
    $"Você economizou {preco - CalcularDesconto.Desconto(preco, desconto):F2}");
