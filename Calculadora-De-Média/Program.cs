using Calculadora_De_Média;
using System;
using System.Globalization;


Console.WriteLine("Digite um sua nota (AV1): ");
double aV1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.WriteLine("Digite um sua nota (AV2): ");
double av2 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota do seu trabalho: ");
double tab = double.Parse(Console.ReadLine());


Contas C = new Contas(aV1,av2,tab);

Console.WriteLine("Sua Média é " + C.Media().ToString ("F2"), CultureInfo.InvariantCulture);