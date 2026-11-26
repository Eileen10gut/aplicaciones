public enum Magnitud
{
    Voltaje = 1,
    Corriente = 2,
    Resistencia = 3
}

public class LeyOhm
{
    // Campos privados (encapsulación)
    private double voltaje;
    private double corriente;
    private double resistencia;

    public Magnitud Objetivo { get; set; }

    public double Voltaje
    {
        get { return voltaje; }
        set
        {
            if (value <= 0) throw new ArgumentException("El voltaje debe ser mayor que 0.");
            voltaje = value;
        }
    }

    public double Corriente
    {
        get { return corriente; }
        set
        {
            if (value <= 0) throw new ArgumentException("La corriente debe ser mayor que 0.");
            corriente = value;
        }
    }

    public double Resistencia
    {
        get { return resistencia; }
        set
        {
            if (value <= 0) throw new ArgumentException("La resistencia debe ser mayor que 0.");
            resistencia = value;
        }
    }

    // Fórmulas de la ley de Ohm
    public double Calcular()
    {
        switch (Objetivo)
        {
            case Magnitud.Voltaje:
                return corriente * resistencia;   // V = I * R
            case Magnitud.Corriente:
                return voltaje / resistencia;     // I = V / R
            case Magnitud.Resistencia:
                return voltaje / corriente;       // R = V / I
            default:
                return 0;
        }
    }

    // Se acepta un margen de error del 1%
    public bool VerificarRespuesta(double respuestaUsuario)
    {
        double correcto = Calcular();
        return Math.Abs(respuestaUsuario - correcto) <= Math.Abs(correcto) * 0.01;
    }

    public static string ObtenerUnidadBase(Magnitud magnitud)
    {
        switch (magnitud)
        {
            case Magnitud.Voltaje: return "V";
            case Magnitud.Corriente: return "A";
            default: return "ohm";
        }
    }

    public static string ObtenerUnidadesDisponibles(Magnitud magnitud)
    {
        switch (magnitud)
        {
            case Magnitud.Voltaje: return "mV, V, kV";
            case Magnitud.Corriente: return "uA, mA, A";
            default: return "ohm, kohm, Mohm";
        }
    }

    // Devuelve el factor para pasar la unidad a la unidad base (-1 si no es válida)
    public static double ObtenerFactor(Magnitud magnitud, string unidad)
    {
        switch (magnitud)
        {
            case Magnitud.Voltaje:
                if (unidad == "mV") return 0.001;
                if (unidad == "V") return 1;
                if (unidad == "kV") return 1000;
                break;
            case Magnitud.Corriente:
                if (unidad == "uA") return 0.000001;
                if (unidad == "mA") return 0.001;
                if (unidad == "A") return 1;
                break;
            case Magnitud.Resistencia:
                if (unidad == "ohm") return 1;
                if (unidad == "kohm") return 1000;
                if (unidad == "Mohm") return 1000000;
                break;
        }
        return -1;
    }
}