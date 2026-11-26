public class LeyOhmControlador
{
    private LeyOhm modelo;
    private LeyOhmVista vista;

    public LeyOhmControlador(LeyOhm modelo, LeyOhmVista vista)
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

            Magnitud objetivo = vista.PedirMagnitud();
            modelo.Objetivo = objetivo;

            // Se piden solo las dos magnitudes conocidas
            if (objetivo != Magnitud.Voltaje)
                modelo.Voltaje = vista.PedirMedida(Magnitud.Voltaje, "Voltaje conocido");

            if (objetivo != Magnitud.Corriente)
                modelo.Corriente = vista.PedirMedida(Magnitud.Corriente, "Corriente conocida");

            if (objetivo != Magnitud.Resistencia)
                modelo.Resistencia = vista.PedirMedida(Magnitud.Resistencia, "Resistencia conocida");

            double respuesta = vista.PedirMedida(objetivo, "¿Cual cree que es el resultado?");

            double correcto = modelo.Calcular();
            string unidad = LeyOhm.ObtenerUnidadBase(objetivo);

            if (modelo.VerificarRespuesta(respuesta))
                vista.MostrarAcierto(correcto, unidad);
            else
                vista.MostrarError(correcto, unidad);

            repetir = vista.PreguntarRepetir();

        } while (repetir);

        vista.MostrarMensaje("Gracias por usar la calculadora.");
    }
}