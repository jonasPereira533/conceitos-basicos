using exemplosCSharp.fixacao;

Console.WriteLine("Informe a medida em metros: ");
int metros = int.Parse(Console.ReadLine());

int milimetros = MetrosMilimetros.Converter(metros);

Console.WriteLine($"A medida {metros}m corresponde a {milimetros}mm");