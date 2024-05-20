  Console.WriteLine("Calculadora de Área y Perímetro de un Rectángulo");

        Console.Write("Ingrese la longitud del rectángulo: ");
        double longitud = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la anchura del rectángulo: ");
        double anchura = Convert.ToDouble(Console.ReadLine());

        
        double area = longitud * anchura;
        double perimetro = 2 * (longitud + anchura);

        Console.WriteLine($"El área del rectángulo es: {area}");
        Console.WriteLine($"El perímetro del rectángulo es: {perimetro}");
    
