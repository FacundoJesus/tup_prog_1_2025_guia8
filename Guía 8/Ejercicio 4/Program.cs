namespace Ejercicio_4
{
    internal class Program
    {
        #region Atributos 
        static string jugador1;
        static string jugador2;
        static int setGanados1;
        static int setGanados2;
        #endregion

        #region Métodos de proceso
        static void RegistrarJugadores(string nombre1, string nombre2)
        {
            Program.jugador1 = nombre1;
            Program.jugador2 = nombre2;
        }
        static void RegistrarResultadoSet(int resultado1, int resultado2)
        {
           if (resultado1 > resultado2)
            {
                setGanados1++;
            }
           else
            {
                setGanados2++;
            }

        }
        static string DeterminarGanador()
        {
            string ganador = "";
            if (setGanados1 > setGanados2) {
                ganador = jugador1;
            }
            else
            {
                ganador = jugador2;
            }
            return ganador;
        }
        #endregion

        #region Métodos para imprimir en pantalla
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("---MENU---");
            Console.WriteLine("1- Registrar los nombres de los dos jugadores");
            Console.WriteLine("2- Registrar los resultados de cada set de los jugadores");
            Console.WriteLine("3- Mostrar el ganador");
            Console.WriteLine("-1 Para Salir");
            int opc = Convert.ToInt32 (Console.ReadLine());
            return opc;

        }
        static void MostrarPantallaSolicitarNombreJugadores()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nombre del 1º Jugador:");
            string name1 = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del 2º Jugador:");
            string name2 = Console.ReadLine();
            RegistrarJugadores (name1, name2);
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadKey();

        }
        static void MostrarPantallaSolicitarResultadosSet()
        {
            Console.Clear();
            for (int nroSet = 0; nroSet < 3; nroSet++) {
                Console.WriteLine($"Ingrese el Puntaje del {nroSet + 1}º Set del Jugador 1:");
                int ptos_setJ1 = Convert.ToInt32 (Console.ReadLine());
                Console.WriteLine($"Ingrese el Puntaje del {nroSet + 1}º Set del Jugador 2:");
                int ptos_setJ2 = Convert.ToInt32(Console.ReadLine());
                RegistrarResultadoSet(ptos_setJ1 , ptos_setJ2);
            }
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadKey();
        }
        static void MostrarPantallaGanador()
        {
            Console.Clear();
            Console.WriteLine($"El ganador del Juego es:");
            string ganadorJuego = DeterminarGanador();
            Console.WriteLine(ganadorJuego + " Felicitaciones!!!");
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadKey();
        }
        #endregion

        #region Menu
        static void Main(string[] args)
        {
            int opcion = MostrarPantallaSolicitarOpcionMenu();

            while(opcion != -1)
            {
                switch(opcion) {
                    case 1:
                        MostrarPantallaSolicitarNombreJugadores();
                        break;
                    case 2:
                        MostrarPantallaSolicitarResultadosSet();
                        break;
                    case 3:
                        MostrarPantallaGanador();
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
