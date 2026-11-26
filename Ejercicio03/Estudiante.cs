public class Estudiante
{
    public string Nombre { get; set; } = "";
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }
    public double Nota3 { get; set; }

    public double CalcularPromedio()
    {
        return (Nota1 + Nota2 + Nota3) / 3;
    }

    public string Clasificar()
    {
        double promedio = CalcularPromedio();

        if (promedio < 3.0)
            return "Bajo";
        else if (promedio < 4.0)
            return "Basico";
        else if (promedio < 4.6)
            return "Alto";
        else
            return "Superior";
    }

    public string ObtenerRecomendacion()
    {
        switch (Clasificar())
        {
            case "Bajo":
                return "Necesita reforzar sus aprendizajes.";
            case "Basico":
                return "Cumple lo minimo, conviene reforzar algunos temas.";
            case "Alto":
                return "Buen desempeño.";
            default:
                return "Desempeño excelente.";
        }
    }
}