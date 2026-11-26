public class Iluminacion
{
    public const double Minimo = 0;
    public const double Maximo = 100;

    private double nivel;

    // Propiedad con validación (encapsulación)
    public double Nivel
    {
        get { return nivel; }
        set
        {
            if (value < Minimo || value > Maximo)
                throw new ArgumentOutOfRangeException(nameof(value), "El nivel debe estar entre 0 y 100.");
            nivel = value;
        }
    }

    public static bool EsValido(double valor)
    {
        return valor >= Minimo && valor <= Maximo;
    }

    public string Clasificar()
    {
        if (nivel < 30)
            return "Oscuridad";
        else if (nivel <= 70)
            return "Luz moderada";
        else
            return "Mucha luz";
    }

    public string ObtenerRecomendacion()
    {
        if (nivel < 30)
            return "Se recomienda encender las luces del salon.";
        else if (nivel <= 70)
            return "La iluminacion es adecuada.";
        else
            return "Se puede apagar alguna luz para ahorrar energia.";
    }
}