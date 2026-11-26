public class TemporizadorVista
{
    public void MostrarTitulo()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=====================================");
        Console.WriteLine("   TEMPORIZADOR PARA ACTIVIDADES");
        Console.WriteLine("=====================================");
        Console.ResetColor();
    }

    public int PedirSegundos()
    {
        int valor;
        Console.Write($"Segundos para la cuenta regresiva (1 a {Temporizador.Maximo}): ");
        while (!int.TryParse(Console.ReadLine(), out valor) || !Temporizador.EsValido(valor))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"Valor invalido. Ingrese un entero entre 1 y {Temporizador.Maximo}: ");
            Console.ResetColor();
        }
        return valor;
    }

    public void MostrarNumero(int numero)
    {
        Console.WriteLine(numero);
    }

    public void MostrarFinal()
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Tiempo finalizado");
        Console.ResetColor();
    }

    public bool PreguntarRepetir()
    {
        Console.WriteLine();
        Console.Write("¿Desea iniciar otra cuenta regresiva? (s/n): ");
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