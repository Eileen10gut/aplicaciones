public class CalculadoraControlador
{
    private Calculadora modelo;
    private CalculadoraVista vista;

    public CalculadoraControlador(Calculadora modelo, CalculadoraVista vista)
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

            modelo.Numero1 = vista.PedirNumero("Primer numero: ");
            modelo.Numero2 = vista.PedirNumero("Segundo numero: ");
            modelo.Operacion = vista.PedirOperacion();

            if (modelo.EsDivisionPorCero())
            {
                vista.MostrarMensaje("Error: no se puede dividir entre cero.");
            }
            else
            {
                double respuesta = vista.PedirRespuesta();

                if (modelo.VerificarRespuesta(respuesta))
                    vista.MostrarAcierto();
                else
                    vista.MostrarError(modelo.Calcular());
            }

            repetir = vista.PreguntarRepetir();

        } while (repetir);

        vista.MostrarMensaje("Gracias por usar la calculadora.");
    }
}