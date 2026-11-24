public class CalculadoraVista
{
    public void MostrarTitulo()
    {
        Console.WriteLine("=====================================");
        Console.WriteLine("   CALCULADORA PARA LA PAPELERIA");
        Console.WriteLine("=====================================");
    }

    public double PedirNumero(string mensaje)
    {
        double numero;
        Console.Write(mensaje);
        while (!double.TryParse(Console.ReadLine(), out numero))
        {
            Console.Write("Dato invalido. Ingrese un numero valido: ");
        }
        return numero;
    }

    public char PedirOperacion()
    {
        Console.Write("Operacion (+, -, *, /): ");
        string? texto = Console.ReadLine();
        while (texto == null || texto.Length != 1 || "+-*/".IndexOf(texto[0]) < 0)
        {
            Console.Write("Operacion invalida. Use +, -, * o /: ");
            texto = Console.ReadLine();
        }
        return texto[0];
    }

    public double PedirRespuesta()
    {
        return PedirNumero("¿Cual cree que es el resultado? ");
    }

    public void MostrarAcierto()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("¡Correcto! Muy bien.");
        Console.ResetColor();
    }

    public void MostrarError(double resultadoCorrecto)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Incorrecto. El resultado correcto es: {resultadoCorrecto:F2}");
        Console.ResetColor();
    }

    public void MostrarMensaje(string mensaje)
    {
        Console.WriteLine(mensaje);
    }

    public bool PreguntarRepetir()
    {
        Console.Write("¿Desea repetir el ejercicio? (s/n): ");
        string? respuesta = Console.ReadLine();
        while (respuesta == null || (respuesta.ToLower() != "s" && respuesta.ToLower() != "n"))
        {
            Console.Write("Responda s o n: ");
            respuesta = Console.ReadLine();
        }
        return respuesta.ToLower() == "s";
    }
}