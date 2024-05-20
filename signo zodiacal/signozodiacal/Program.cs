
        Console.WriteLine("Calculadora de Signo Zodiacal");

        Console.Write("Ingrese su mes de nacimiento (número): ");
        int mesNacimiento = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese su día de nacimiento: ");
        int diaNacimiento = Convert.ToInt32(Console.ReadLine());

        string[] signosZodiaco = {
            "Capricornio", "Acuario", "Piscis", "Aries", "Tauro", "Géminis",
            "Cáncer", "Leo", "Virgo", "Libra", "Escorpio", "Sagitario"
        };

        int signoIndex = (mesNacimiento - 1) % 12;
        string signoZodiacal = signosZodiaco[signoIndex];

        Console.WriteLine($"Su signo zodiacal es: {signoZodiacal}");