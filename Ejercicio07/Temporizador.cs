public class Temporizador
{
    public const int Maximo = 3600; // límite de 1 hora para evitar esperas enormes

    private int segundos;

    // Propiedad con validación (encapsulación)
    public int Segundos
    {
        get { return segundos; }
        set
        {
            if (!EsValido(value))
                throw new ArgumentOutOfRangeException(nameof(value), "Los segundos deben ser un entero positivo.");
            segundos = value;
        }
    }

    public static bool EsValido(int valor)
    {
        return valor > 0 && valor <= Maximo;
    }

    // Espera un segundo (simula el paso del tiempo)
    public void EsperarUnSegundo()
    {
        Thread.Sleep(1000);
    }
}