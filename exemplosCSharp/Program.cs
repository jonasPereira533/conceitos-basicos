using exemplosCSharp.fixacao;


Console.WriteLine("Informe o salario atual: ");
int salario = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o percentual de aumento: ");
int aumento = int.Parse(Console.ReadLine());

Console.WriteLine($"seu salario atual é: {salario}");
Console.WriteLine($"Com o aumento seu salario será: {Calculadora.Somar(salario, aumento)}");
