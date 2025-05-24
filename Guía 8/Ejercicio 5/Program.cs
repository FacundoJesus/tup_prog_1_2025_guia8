namespace Ejercicio_5
{
    internal class Program
    {
        #region Declaracion de variables

        #endregion

        #region Metodos del proceso
        static void DeterminarLosDiasDelMes(int mes, int año)
        {
            if (mes == 2)
            {
                if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
                {
                    Console.WriteLine("29 días");
                }
                else
                {
                    Console.WriteLine("28 días");
                }
            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                Console.WriteLine("30 días");
            }
            else
            {
                Console.WriteLine("31 días");
            }
        }
        static bool DeterminarSiEsBisiesto(int año)
        {
            if (año % 4 == 0)
            {
                if (año % 100 != 0 || año % 4 == 0)
                { 
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region Metodos de Pantalla
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("MENU");
            Console.WriteLine("Elija la opción deseada:");
            Console.WriteLine("1- Determinar Cantidad de Días del mes.");
            Console.WriteLine("2- Verificar Si el año es bisiesto.");
            Console.WriteLine("Presione -1 Para Salir");
            int opc = Convert.ToInt32(Console.ReadLine());
            return opc;
        }
        static void MostrarPantallaSolicitarMesAñoYDeterminarDias()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el número del mes: (1-12)");
            int nMes = Convert.ToInt32(Console.ReadLine());
            if (nMes < 1 || nMes > 12)
            {
                Console.WriteLine("Número de mes no válido");
            }
            else
            {
                Console.WriteLine("Ingrese el año:");
                int año = Convert.ToInt32(Console.ReadLine());
                DeterminarLosDiasDelMes(nMes, año);
            }

            Console.WriteLine("\nPresione Enter para continuar");
            Console.ReadKey();
        }
        static void MostrarPantallaVerificarSiElAñoEsBisiesto()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el año para verificar si es bisiesto o no:");
            int año = Convert.ToInt32 (Console.ReadLine());
            Console.Clear();
            bool BisiestoONo = DeterminarSiEsBisiesto(año);
            if (BisiestoONo==true) 
            {
                Console.WriteLine("El año es Bisiesto.");
            }
            else
            {
                Console.WriteLine("El año no es Bisiesto.");
            }
            Console.WriteLine("\nPresione Enter para continuar");
            Console.ReadKey();

        }
        #endregion

        #region Menu
        static void Main(string[] args)
        {
            int opcion = MostrarPantallaSolicitarOpcionMenu();

            while(opcion !=-1)
            {
                switch(opcion) {
                    case 1:
                        MostrarPantallaSolicitarMesAñoYDeterminarDias();
                        break;
                    case 2:
                        MostrarPantallaVerificarSiElAñoEsBisiesto();
                        break;
                    default:
                        opcion = -1;
                        break;
                }

                if (opcion != -1)
                {
                    opcion = MostrarPantallaSolicitarOpcionMenu();
                }
            }
        }
        #endregion
    }
}
