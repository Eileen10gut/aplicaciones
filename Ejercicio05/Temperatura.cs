public class Temperatura
{
    public const double CeroAbsolutoCelsius = -273.15;

    public double Celsius { get; set; }

    // F = C * 9/5 + 32
    public double ConvertirAFahrenheit()
    {
        return Celsius * 9 / 5 + 32;
    }

    public bool EsValida()
    {
        return Celsius >= CeroAbsolutoCelsius;
    }
}