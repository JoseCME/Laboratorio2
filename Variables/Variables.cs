using System;


        int entero = 0;
        double decimales = 0.0;
        string texto = string.Empty;
        bool booleano = false;

        Console.Write("Introduce un número entero:");
        try
        {
            entero = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("El valor introducido no es un numero entero");
        }

        Console.Write("Introduce un número decimal:");
        try
        {
            decimales = Convert.ToDouble(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("El valor introducido no es un numero decimal");
        }

        Console.Write("Introduce un texto:");
        try
        {
            texto = Console.ReadLine() ?? string.Empty;
        }
        catch (FormatException)
        {
            Console.WriteLine("El valor introducido no es un texto");
        }

        Console.Write("Introduce un valor booleano:");
        try
        {
            booleano = Convert.ToBoolean(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("El valor introducido no es un valor booleano");
        }

        Console.WriteLine($"El valor entero introducido es: {entero}");
        Console.WriteLine($"El valor decimal introducido es: {decimales}");
        Console.WriteLine($"El valor de texto introducido es: {texto}");
        Console.WriteLine($"El valor booleano introducido es: {booleano}");
    
