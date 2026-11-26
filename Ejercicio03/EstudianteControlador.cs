public class EstudianteControlador
{
    private Estudiante modelo;
    private EstudianteVista vista;

    public EstudianteControlador(Estudiante modelo, EstudianteVista vista)
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

            modelo.Nombre = vista.PedirNombre();
            modelo.Nota1 = vista.PedirNota("Calificacion 1 (0 a 5): ");
            modelo.Nota2 = vista.PedirNota("Calificacion 2 (0 a 5): ");
            modelo.Nota3 = vista.PedirNota("Calificacion 3 (0 a 5): ");

            vista.MostrarResultado(
                modelo.Nombre,
                modelo.CalcularPromedio(),
                modelo.Clasificar(),
                modelo.ObtenerRecomendacion());

            repetir = vista.PreguntarRepetir();

        } while (repetir);

        vista.MostrarMensaje("Gracias por usar el sistema.");
    }
}