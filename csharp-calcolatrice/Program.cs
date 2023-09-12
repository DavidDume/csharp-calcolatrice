// See https://aka.ms/new-console-template for more information

using csharp_calcolatrice;

Console.WriteLine("SOMMA");
Console.WriteLine(CalcoliHelper.sommaInt(1, 2));

Console.WriteLine("SOMMA DOUBLE");
Console.WriteLine(CalcoliHelper.sommaDouble(1.3, 2.5));


Console.WriteLine("DIFFERENZA");
Console.WriteLine(CalcoliHelper.diffInt(6, 2));

Console.WriteLine("DIFFERENZA DOUBLE");
Console.WriteLine(CalcoliHelper.diffDouble(8.3, 2.5));

Console.WriteLine("MOLTIPLICAZIONE");
Console.WriteLine(CalcoliHelper.moltInt(7, 5));

Console.WriteLine("MOLTIPLICAZIONE DOUBLE");
Console.WriteLine(CalcoliHelper.moltDouble(1.3, 2.5));

Console.WriteLine("MODULO");
Console.WriteLine(CalcoliHelper.moduloInt(54, 2));

Console.WriteLine("MODULO DOUBLE");
Console.WriteLine(CalcoliHelper.moduloDouble(5.1, 26.5));


Console.WriteLine("MINIMO");
Console.WriteLine(CalcoliHelper.minInt(1, 2));

Console.WriteLine("MINIMO DOUBLE");
Console.WriteLine(CalcoliHelper.minDouble(1.3, 2.5));

Console.WriteLine("MASSIMO");
Console.WriteLine(CalcoliHelper.maxInt(54, 2));

Console.WriteLine("MASSIMO DOUBLE");
Console.WriteLine(CalcoliHelper.maxDouble(5.1, 26.5));