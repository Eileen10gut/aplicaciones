public class CircuitoLed
{
    public double VoltajeFuente { get; set; }
    public double VoltajeLed { get; set; }
    public double CorrienteMiliamperios { get; set; }

    // Conversión de mA a A
    public double CorrienteAmperios()
    {
        return CorrienteMiliamperios / 1000;
    }

    // Los datos son coherentes si la fuente supera la caída del LED
    public bool DatosCoherentes()
    {
        return VoltajeFuente > VoltajeLed;
    }

    // R = (Vf - VLED) / I
    public double CalcularResistencia()
    {
        return (VoltajeFuente - VoltajeLed) / CorrienteAmperios();
    }

    // Potencia que disipa la resistencia: P = (Vf - VLED) * I
    public double CalcularPotencia()
    {
        return (VoltajeFuente - VoltajeLed) * CorrienteAmperios();
    }
}