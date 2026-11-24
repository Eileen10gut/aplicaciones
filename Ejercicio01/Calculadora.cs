public class Calculadora
{
    public double Numero1 { get; set; }
    public double Numero2 { get; set; }
    public char Operacion { get; set; }

    public bool EsDivisionPorCero()
    {
        return Operacion == '/' && Numero2 == 0;
    }

    public double Calcular()
    {
        switch (Operacion)
        {
            case '+':
                return Numero1 + Numero2;
            case '-':
                return Numero1 - Numero2;
            case '*':
                return Numero1 * Numero2;
            case '/':
                return Numero1 / Numero2;
            default:
                return 0;
        }
    }

    public bool VerificarRespuesta(double respuestaUsuario)
    {
        return Math.Abs(respuestaUsuario - Calcular()) < 0.01;
    }
}