public class TemperaturaVista
{
    public void MostrarTitulo()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=====================================");
        Console.WriteLine("   CONVERSOR CELSIUS A FAHRENHEIT");
        Console.WriteLine("=====================================");
        Console.ResetColor();
    }

    public double PedirCelsius()
    {
        double valor;
        Console.Write("Temperatura en grados Celsius: ");
        while (!double.TryParse(Console.ReadLine(), out valor))
        {
            Console.Write("Dato invalido. Ingrese un numero: ");
        }
        return valor;
    }

    public void MostrarErrorCeroAbsoluto()
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: no existe una temperatura menor a -273,15 °C (cero absoluto).");
        Console.ResetColor();
    }

    public void MostrarResultado(double celsius, double fahrenheit)
    {
        Console.WriteLine();
        Console.WriteLine("----------- RESULTADO -----------");
        Console.WriteLine($"Celsius:    {celsius:F2} °C");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Fahrenheit: {fahrenheit:F2} °F");
        Console.ResetColor();
    }

    public bool PreguntarRepetir()
    {
        Console.WriteLine();
        Console.Write("¿Desea realizar otra conversion? (s/n): ");
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