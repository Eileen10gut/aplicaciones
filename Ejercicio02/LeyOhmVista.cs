public class LeyOhmVista
{
    public void MostrarTitulo()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=====================================");
        Console.WriteLine("   CALCULADORA DE LA LEY DE OHM");
        Console.WriteLine("=====================================");
        Console.ResetColor();
    }

    public Magnitud PedirMagnitud()
    {
        Console.WriteLine("¿Que magnitud desea calcular?");
        Console.WriteLine("1. Voltaje (V)");
        Console.WriteLine("2. Corriente (A)");
        Console.WriteLine("3. Resistencia (ohm)");
        Console.Write("Opcion: ");

        string? texto = Console.ReadLine();
        while (texto != "1" && texto != "2" && texto != "3")
        {
            Console.Write("Opcion invalida. Elija 1, 2 o 3: ");
            texto = Console.ReadLine();
        }
        return (Magnitud)int.Parse(texto);
    }

    // Pide valor y unidad, y devuelve el valor convertido a la unidad base
    public double PedirMedida(Magnitud magnitud, string mensaje)
    {
        Console.WriteLine();
        Console.WriteLine($"{mensaje} ({magnitud})");

        double valor;
        Console.Write("Valor: ");
        while (!double.TryParse(Console.ReadLine(), out valor) || valor <= 0)
        {
            Console.Write("Dato invalido. Ingrese un numero mayor que 0: ");
        }

        Console.Write($"Unidad ({LeyOhm.ObtenerUnidadesDisponibles(magnitud)}): ");
        string? unidad = Console.ReadLine();
        double factor = LeyOhm.ObtenerFactor(magnitud, unidad ?? "");
        while (factor < 0)
        {
            Console.Write($"Unidad invalida. Use una de: {LeyOhm.ObtenerUnidadesDisponibles(magnitud)}: ");
            unidad = Console.ReadLine();
            factor = LeyOhm.ObtenerFactor(magnitud, unidad ?? "");
        }

        return valor * factor;
    }

    public void MostrarAcierto(double correcto, string unidad)
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("¡Correcto! Muy bien.");
        Console.ResetColor();
        Console.WriteLine($"Resultado: {correcto:G6} {unidad}");
    }

    public void MostrarError(double correcto, string unidad)
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Incorrecto.");
        Console.ResetColor();
        Console.WriteLine($"El resultado correcto es: {correcto:G6} {unidad}");
    }

    public void MostrarMensaje(string mensaje)
    {
        Console.WriteLine(mensaje);
    }

    public bool PreguntarRepetir()
    {
        Console.WriteLine();
        Console.Write("¿Desea hacer otro calculo? (s/n): ");
        string? respuesta = Console.ReadLine();
        while (respuesta == null || (respuesta.ToLower() != "s" && respuesta.ToLower() != "n"))
        {
            Console.Write("Responda s o n: ");
            respuesta = Console.ReadLine();
        }
        return respuesta.ToLower() == "s";
    }
}