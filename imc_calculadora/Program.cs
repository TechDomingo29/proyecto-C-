Console.WriteLine("Calculadora de Índice de Masa Corporal (IMC)");

Console.Write("Ingrese su peso en kilogramos: ");
double peso = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese su altura en metros: ");
double altura = Convert.ToDouble(Console.ReadLine());

        
double imc = peso / (altura * altura);

Console.WriteLine($"Su Índice de Masa Corporal (IMC) es: {imc}");

        
    if (imc < 18.5)
        {
        Console.WriteLine("Peso insuficiente");
        }
        else if (imc >= 18.5 && imc < 25)
        {
            Console.WriteLine("Peso normal");
        }
        else if (imc >= 25 && imc < 30)
        {
            Console.WriteLine("Sobrepeso");
        }
        else
        {
            Console.WriteLine("Obesidad");
        }
 Console.Write("Presiona una tecla para terminar . . . ");
 Console.ReadKey();