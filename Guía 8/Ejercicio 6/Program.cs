namespace Ejercicio_6
{
    internal class Program
    {
        #region Variables de la clase program
        static int indecisos;
        static int negativos;
        static int positivos;
        static int encuestados;
        static double porcentajeIndecisos;
        static double porcentajeNegativos;
        static double porcentajePositivos;
        #endregion

        #region Métodos de proceso
        static void RegistrarOpinion(int opinion)
        {
            switch (opinion)
            {
                case 0:
                    positivos++;
                    break;
                case 1:
                    negativos++;
                    break;
                case 2:
                    indecisos++;
                    break;
                default:
                    Console.WriteLine("Opinión no válida");
                    break;
            }
            encuestados = positivos + negativos + indecisos;
        }
        static void ProcesarEncuesta()
        {
            if (encuestados > 0)
            {
                porcentajeIndecisos = (indecisos * 1.0 / encuestados) * 100;
                porcentajeNegativos = (negativos * 1.0 / encuestados) * 100;
                porcentajePositivos = (positivos * 1.0 / encuestados) * 100;
                Console.WriteLine($"Porcentaje de Indecisos: {porcentajeIndecisos:f2}% / Cantidad de Indecisos: {indecisos}");
                Console.WriteLine($"Porcentaje de Negativos: {porcentajeNegativos:f2}% / Cantidad de Negativos: {negativos}");
                Console.WriteLine($"Porcentaje de Positivos: {porcentajePositivos:f2}% / Cantidad de Positivos: {positivos}");
                Console.WriteLine($"Cantidad de Encuestados: {encuestados}");
            }
            else
            {
                Console.WriteLine("No hubo encuestados.");
            }
        }
        #endregion

        #region Métodos para imprimir en pantalla
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();

            Console.WriteLine("---MENU---");
            Console.WriteLine("Bienvenido a la Encuesta");
            Console.WriteLine("1- Registrar opinión");
            Console.WriteLine("2- Procesar y mostrar resultados encuesta");
            Console.WriteLine("-1 Para salir");
            int opt = Convert.ToInt32(Console.ReadLine());
            return opt;

        }
        static void MostrarPantallaRegistrarEncuesta()
        {
            Console.Clear();
           
            Console.WriteLine("Ingrese la opinión:\n0 - Positivo\n1 - Negativo\n2 - Indeciso\n-1 Para Salir");
            int opinion = Convert.ToInt32(Console.ReadLine());
            
            while (opinion != -1)
            {
                
                RegistrarOpinion(opinion);
                
                Console.Clear();
                Console.WriteLine("Ingrese la opinión:\n0 - Positivo\n1 - Negativo\n2 - Indeciso\n-1 Para Salir");
                opinion = Convert.ToInt32(Console.ReadLine());
                
            }
            

        }
        static void MostrarPantallaProcesarMostrarResultadosEncuesta()
        {
            Console.Clear();
            ProcesarEncuesta();
            Console.WriteLine("Presione Enter para volver al Menú principal");
            Console.ReadKey();
        }
        #endregion

        #region Menú consola
        static void Main(string[] args)
        {
            int opcion = MostrarPantallaSolicitarOpcionMenu();
            while(opcion != -1)
            {
                switch (opcion) {
                    case 1:
                        MostrarPantallaRegistrarEncuesta();
                        break;
                    case 2:
                        MostrarPantallaProcesarMostrarResultadosEncuesta();
                        break;
                    default:
                        opcion = -1;
                        break;
                }
                if (opcion!=-1)
                {
                    opcion = MostrarPantallaSolicitarOpcionMenu();
                }
            }
        }
        #endregion 
    }
}
