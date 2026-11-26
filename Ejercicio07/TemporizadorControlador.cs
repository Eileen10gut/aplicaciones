public class TemporizadorControlador
{
    private Temporizador modelo;
    private TemporizadorVista vista;

    public TemporizadorControlador(Temporizador modelo, TemporizadorVista vista)
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

            modelo.Segundos = vista.PedirSegundos();
            Console.WriteLine();

            // Ciclo for descendente hasta llegar a cero
            for (int i = modelo.Segundos; i >= 0; i--)
            {
                vista.MostrarNumero(i);
                if (i > 0)
                    modelo.EsperarUnSegundo();
            }

            vista.MostrarFinal();

            repetir = vista.PreguntarRepetir();

        } while (repetir);

        vista.MostrarMensaje("Gracias por usar el temporizador.");
    }
}