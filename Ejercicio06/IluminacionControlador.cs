public class IluminacionControlador
{
    private Iluminacion modelo;
    private IluminacionVista vista;

    public IluminacionControlador(Iluminacion modelo, IluminacionVista vista)
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

            modelo.Nivel = vista.PedirNivel();

            vista.MostrarResultado(
                modelo.Nivel,
                modelo.Clasificar(),
                modelo.ObtenerRecomendacion());

            repetir = vista.PreguntarRepetir();

        } while (repetir);

        vista.MostrarMensaje("Gracias por usar el clasificador.");
    }
}