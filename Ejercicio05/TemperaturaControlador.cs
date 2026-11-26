public class TemperaturaControlador
{
    private Temperatura modelo;
    private TemperaturaVista vista;

    public TemperaturaControlador(Temperatura modelo, TemperaturaVista vista)
    {
        this.modelo = modelo;
        this.vista = vista;
    }

    public void Iniciar()
    {
        bool repetir;

        do
        {
            Console.Clear();
            vista.MostrarTitulo();

            modelo.Celsius = vista.PedirCelsius();

            if (!modelo.EsValida())
            {
                vista.MostrarErrorCeroAbsoluto();
            }
            else
            {
                vista.MostrarResultado(modelo.Celsius, modelo.ConvertirAFahrenheit());
            }

            repetir = vista.PreguntarRepetir();

        } while (repetir);

        vista.MostrarMensaje("Gracias por usar el conversor.");
    }
}