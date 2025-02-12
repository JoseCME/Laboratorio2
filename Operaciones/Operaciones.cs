using System;

decimal n1 = 0, n2 = 0;
Console.Write("Introduce tu primer número (decimal): ");
try
{
    n1 = Convert.ToDecimal(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("El valor introducido no es un número.");
}

Console.Write("Introduce tu segundo número (decimal): ");
try
{
    n2 = Convert.ToDecimal(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("El valor introducido no es un número.");
}

Console.WriteLine($"La suma de {n1} y {n2} es {n1 + n2}");
Console.WriteLine($"La resta de {n1} y {n2} es {n1 - n2}");
Console.WriteLine($"La multiplicación de {n1} y {n2} es {n1 * n2}");
if (n2 != 0)
{
    Console.WriteLine($"La división de {n1} y {n2} es {n1 / n2}");
}
else
{
    Console.WriteLine("No se puede dividir por cero.");
}

float n3 = 0, n4 = 0;
Console.Write("Introduce tu primer número (float): ");
try
{
    n3 = Convert.ToSingle(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("El valor introducido no es un número.");
}

Console.Write("Introduce tu segundo número (float): ");
try
{
    n4 = Convert.ToSingle(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("El valor introducido no es un número.");
}

Console.WriteLine($"La suma de {n3} y {n4} es {n3 + n4}");
Console.WriteLine($"La resta de {n3} y {n4} es {n3 - n4}");
Console.WriteLine($"La multiplicación de {n3} y {n4} es {n3 * n4}");
if (n4 != 0)
{
    Console.WriteLine($"La división de {n3} y {n4} es {n3 / n4}");
}
else
{
    Console.WriteLine("No se puede dividir por cero.");
}

short n5 = 0, n6 = 0;
Console.Write("Introduce tu primer número (int16): ");
try
{
    n5 = Convert.ToInt16(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("El valor introducido no es un número.");
}

Console.Write("Introduce tu segundo número (int16): ");
try
{
    n6 = Convert.ToInt16(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("El valor introducido no es un número.");
}

Console.WriteLine($"La suma de {n5} y {n6} es {n5 + n6}");
Console.WriteLine($"La resta de {n5} y {n6} es {n5 - n6}");
Console.WriteLine($"La multiplicación de {n5} y {n6} es {n5 * n6}");
if (n6 != 0)
{
    Console.WriteLine($"La división de {n5} y {n6} es {n5 / n6}");
}
else
{
    Console.WriteLine("No se puede dividir por cero.");
}

byte n7 = 0, n8 = 0;
Console.Write("Introduce tu primer número (byte): ");
try
{
    n7 = Convert.ToByte(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("El valor introducido no es un número.");
}

Console.Write("Introduce tu segundo número (byte): ");
try
{
    n8 = Convert.ToByte(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("El valor introducido no es un número.");
}

Console.WriteLine($"La suma de {n7} y {n8} es {n7 + n8}");
Console.WriteLine($"La resta de {n7} y {n8} es {n7 - n8}");
Console.WriteLine($"La multiplicación de {n7} y {n8} es {n7 * n8}");
if (n8 != 0)
{
    Console.WriteLine($"La división de {n7} y {n8} es {n7 / n8}");
}
else
{
    Console.WriteLine("No se puede dividir por cero.");
}
    