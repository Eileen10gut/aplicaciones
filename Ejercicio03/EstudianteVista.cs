public class EstudianteVista
{
    public void MostrarTitulo()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=====================================");
        Console.WriteLine("   SISTEMA DE PROMEDIO ACADEMICO");
        Console.WriteLine("=====================================");
        Console.ResetColor();
    }

    public string PedirNombre()
    {
        Console.Write("Nombre del estudiante: ");
        string? nombre = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(nombre))
        {
            Console.Write("El nombre no puede estar vacio. Intente de nuevo: ");
            nombre = Console.ReadLine();
        }
        return nombre.Trim();
    }

    public double PedirNota(string mensaje)
    {
        double nota;
        Console.Write(mensaje);
        while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 5)
        {
            Console.Write("Dato invalido. Ingrese una nota entre 0 y 5: ");
        }
        return nota;
    }

    public void MostrarResultado(string nombre, double promedio, string nivel, string recomendacion)
    {
        Console.WriteLine();
        Console.WriteLine("----------- RESULTADO -----------");
        Console.WriteLine($"Estudiante: {nombre}");
        Console.WriteLine($"Promedio:   {promedio:F2}");

        switch (nivel)
        {
            case "Bajo":
                Console.ForegroundColor = ConsoleColor.Red;
                break;
            case "Basico":
                Console.ForegroundColor = ConsoleColor.Yellow;
                break;
            case "Alto":
                Console.ForegroundColor = ConsoleColor.Green;
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Cyan;
                break;
        }

        Console.WriteLine($"Nivel:      {nivel}");
        Console.ResetColor();
        Console.WriteLine(recomendacion);
    }

    public bool PreguntarRepetir()
    {
        Console.WriteLine();
        Console.Write("¿Desea evaluar otro estudiante? (s/n): ");
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