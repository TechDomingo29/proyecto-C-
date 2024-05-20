﻿  Console.WriteLine("Calculadora Simple");
        
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Seleccione la operación:");
        Console.WriteLine("1 - Suma");
        Console.WriteLine("2 - Resta");
        Console.WriteLine("3 - Multiplicación");
        Console.WriteLine("4 - División");
        
        int opcion = Convert.ToInt32(Console.ReadLine());
        double resultado = 0;

        switch (opcion)
        {
            case 1:
                resultado = num1 + num2;
                break;
            case 2:
                resultado = num1 - num2;
                break;
            case 3:
                resultado = num1 * num2;
                break;
            case 4:
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: No se puede dividir por cero.");
                }
                break;
            default:
                Console.WriteLine("Opción inválida.");
                break;
        }
        
        Console.WriteLine("El resultado es: " + resultado);