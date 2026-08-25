using exemplosCSharp.fixacao;


/*    PRIMEIRO EXERCICIO 
Console.WriteLine("Informe o salario atual: ");
int salario = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o percentual de aumento: ");
int aumento = int.Parse(Console.ReadLine());

Console.WriteLine($"seu salario atual é: {salario}");
Console.WriteLine($"Com o aumento seu salario será: {Calculadora.Somar(salario, aumento)}");



 SEGUNDO EXERCICIO
Console.WriteLine("Informe o preço do produto: ");
double preco = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o percentual de desconto: ");
double desconto = double.Parse(Console.ReadLine());

Console.WriteLine
    ($"O preço do produto com desconto é: {CalcularDesconto.Desconto(preco, desconto)}" + "\n" +
    $"Você economizou {preco - CalcularDesconto.Desconto(preco, desconto):F2}");



Console.WriteLine("Informe a quantidade de dias que ficou com o carro: ");
int dias = int.Parse(Console.ReadLine());

Console.WriteLine("Kilometragem inicial do carro: ");
int kmInicial = int.Parse(Console.ReadLine());

Console.WriteLine("Kilometragem final do carro: ");
int kmFinal = int.Parse(Console.ReadLine());

int kmRodados = kmFinal - kmInicial;

Console.WriteLine($"O valor a ser pago é: " +
    $"{AluguelCarro.CalcularAluguel(dias, kmRodados):F2}");
*/

decimal salario, valorAumento, novoSalario;
float percentual = 10;

Console.WriteLine("Informe o salario: ");
salario = decimal.Parse(Console.ReadLine());
Console.WriteLine("Informe o percentual de aumento: ");
percentual = float.Parse(Console.ReadLine());

CalculaAumento calc = new CalculaAumento();
valorAumento = calc.AumentarSalario(salario, percentual);

Console.WriteLine($"para o salário {salario} com o aumento de {percentual}%, o valor do aumento é {valorAumento} e o novo salário é {salario + valorAumento}");

