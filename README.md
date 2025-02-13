# Laboratorio 2

## Preguntas

### ¿Para qué crees que se usan los operadores lógicos en programación?
Se usan para evaluar o comparar distintos tipos de datos, en mi programa se ingresa algun dato y si es incorrecto se devulve como false o sea un booleano, esto puede servir para todo tipo de verificaciones

### ¿Por qué es importante declarar correctamente el tipo de dato de una variable?

Mejora la claridad del codigo, ya que si hablamos de los nombres de las variables ayuda a que nos guiemos de que se trata esa variable, pero si hablamos del tipo ayuda a que la memoria no se esfuerce y sepa que dato sera ingresado


## Anunciados



## Enunciado 1: Clasificación de Edad
Utilize `if-else` porque me permite evaluar rangos de valores de manera flexible.

### Código:

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());

        if (edad < 12)
            Console.WriteLine("Niño");
        else if (edad >= 12 && edad <= 17)
            Console.WriteLine("Adolescente");
        else if (edad >= 18 && edad <= 59)
            Console.WriteLine("Adulto");
        else
            Console.WriteLine("Adulto mayor");
    }
}
```

---

## Enunciado 2: Día de la Semana
Utilice `switch` porque se me hace mas facil evaluar como si fuera una lista.
### Código:

```csharp
Console.Write("Ingrese un número del 1 al 7: ");
int dia = int.Parse(Console.ReadLine());

switch (dia)
{
    case 1: Console.WriteLine("Lunes"); break;
    case 2: Console.WriteLine("Martes"); break;
    case 3: Console.WriteLine("Miércoles"); break;
    case 4: Console.WriteLine("Jueves"); break;
    case 5: Console.WriteLine("Viernes"); break;
    case 6: Console.WriteLine("Sábado"); break;
    case 7: Console.WriteLine("Domingo"); break;
    default: Console.WriteLine("Número inválido"); break;
}
```

---

## Enunciado 3: Verificación de Acceso
Utilice `if-else` porque porque tenia que evular distintas condiciones.

### Código:

```csharp
string usuarioCorrecto = "admin";
string contrasenaCorrecta = "1234";

Console.Write("Ingrese su usuario: ");
string usuario = Console.ReadLine();

Console.Write("Ingrese su contraseña: ");
string contrasena = Console.ReadLine();

if (usuario == usuarioCorrecto && contrasena == contrasenaCorrecta)
    Console.WriteLine("Acceso concedido");
else if (usuario == usuarioCorrecto)
    Console.WriteLine("Contraseña incorrecta");
else
    Console.WriteLine("Usuario no registrado");
```

---
