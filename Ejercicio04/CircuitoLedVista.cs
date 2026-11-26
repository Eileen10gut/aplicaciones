public class CircuitoLedVista
{
    public void MostrarTitulo()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=====================================");
        Console.WriteLine("   RESISTENCIA PARA UN LED");
        Console.WriteLine("=====================================");
        Console.ResetColor();
    }

    public double PedirValor(string mensaje, bool permitirCero)
    {
        double valor;
        Console.Write(mensaje);
        while (!double.TryParse(Console.ReadLine(), out valor)
               || valor < 0
               || (!permitirCero && valor == 0))
        {
            Console.Write(permitirCero
                ? "Dato invalido. Ingrese un numero mayor o igual a 0: "
                : "Dato invalido. Ingrese un numero mayor que 0: ");
        }
        return valor;
    }

    public void MostrarIncoherencia()
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: el voltaje de la fuente debe ser mayor que la caida del LED.");
        Console.ResetColor();
    }

    public void MostrarResultado(double resistencia, double potencia)
    {
        Console.WriteLine();
        Console.WriteLine("----------- RESULTADO -----------");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Resistencia necesaria: {resistencia:F2} ohm");
        Console.ResetColor();
        Console.WriteLine($"Potencia en la resistencia: {potencia * 1000:F2} mW");
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

    public void MostrarMensaje(string mensaje)
    {
        Console.WriteLine(mensaje);
    }
}