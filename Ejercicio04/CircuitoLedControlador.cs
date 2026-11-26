public class CircuitoLedControlador
{
    private CircuitoLed modelo;
    private CircuitoLedVista vista;

    public CircuitoLedControlador(CircuitoLed modelo, CircuitoLedVista vista)
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

            modelo.VoltajeFuente = vista.PedirValor("Voltaje de la fuente (V): ", false);
            modelo.VoltajeLed = vista.PedirValor("Caida de voltaje del LED (V): ", false);
            modelo.CorrienteMiliamperios = vista.PedirValor("Corriente deseada (mA): ", false);

            if (!modelo.DatosCoherentes())
            {
                vista.MostrarIncoherencia();
            }
            else
            {
                vista.MostrarResultado(
                    modelo.CalcularResistencia(),
                    modelo.CalcularPotencia());
            }

            repetir = vista.PreguntarRepetir();

        } while (repetir);

        vista.MostrarMensaje("Gracias por usar la calculadora.");
    }
}