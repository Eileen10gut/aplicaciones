public class IluminacionVista
{
    public void MostrarTitulo()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=====================================");
        Console.WriteLine("   CLASIFICADOR DE ILUMINACION");
        Console.WriteLine("=====================================");
        Console.ResetColor();
    }

    public double PedirNivel()
    {
        double valor;
        Console.Write("Nivel de iluminacion del sensor (0 a 100): ");
        while (!double.TryParse(Console.ReadLine(), out valor) || !Iluminacion.EsValido(valor))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Valor rechazado. Debe ser un numero entre 0 y 100: ");
            Console.ResetColor();
        }
        return valor;
    }

    public void MostrarResultado(double nivel, string clasificacion, string recomendacion)
    {
        Console.WriteLine();
        Console.WriteLine("----------- RESULTADO -----------");
        Console.WriteLine($"Nivel registrado: {nivel:F1}");

        if (clasificacion == "Oscuridad")
            Console.ForegroundColor = ConsoleColor.Blue;
        else if (clasificacion == "Luz moderada")
            Console.ForegroundColor = ConsoleColor.Green;
        else
            Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine($"Clasificacion:    {clasificacion}");
        Console.ResetColor();
        Console.WriteLine(recomendacion);
    }

    public bool PreguntarRepetir()
    {
        Console.WriteLine();
        Console.Write("¿Desea registrar otra medicion? (s/n): ");
        string? respuesta = Console.ReadLine();
        while (respuesta == null || (respuesta.ToLower() != "s" && respuesta.ToLower() != "n"))
        {
            Console.Write("Responda s o n: ");
            respuesta = Console.ReadLine();
        }
        return respuesta.ToLower() == "s";
    }

    public void MostrarMensaje(string mensaje)
    {
        Console.WriteLine(mensaje);
    }
}