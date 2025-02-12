using System;

int n1 = 0, n2 = 0;
Console.Write("Introduce tu primer numero:");
try {
    n1 = Convert.ToInt32(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("El valor introducido no es un numero");
}
Console.Write("Introduce  tu segundo numero:");
try
{
    n2 = Convert.ToInt32(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("El valor introducido no es un numero");
}
Console.WriteLine($"El mayor entre {n1} y {n2} es: {n1 > n2}");
Console.WriteLine($"El menor entre {n1} y {n2} es: {n1 < n2}");
Console.WriteLine($"¿{n1} es igual a {n2}? {n1 == n2}");
Console.WriteLine($"¿{n1} es mayor que 0 y {n2} es menor que 100? {(n1 > 0 && n2 < 100)}");
Console.WriteLine($"¿{n1} es mayor que 0 o {n2} es menor que 0? {(n1 > 0 || n2 < 0)}");