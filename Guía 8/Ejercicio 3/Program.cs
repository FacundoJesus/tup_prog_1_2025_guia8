using System.Data;

namespace Ejercicio_3
{
    internal class Program
    {
        #region Atributos de la clase Program
        static string nombre0;
        static int numeroLibreta0;
        static string nombre1;
        static int numeroLibreta1;
        static string nombre2;
        static int numeroLibreta2;
        static int orden = 0;
        #endregion

        #region Métodos de proceso
        static void RegistrarNombreYNumeroLibreta(string nombre, int nroLibreta)
        {
            switch (orden)
            {
                case 0:
                    nombre0 = nombre;
                    numeroLibreta0 = nroLibreta;
                    break;
                case 1:
                    if (nroLibreta < numeroLibreta0)
                    {
                        // Mover el primero a la posición 1
                        nombre1 = nombre0;
                        numeroLibreta1 = numeroLibreta0;

                        nombre0 = nombre;
                        numeroLibreta0 = nroLibreta;
                    }
                    else
                    {
                        nombre1 = nombre;
                        numeroLibreta1 = nroLibreta;
                    }
                    break;
                case 2:
                    if (nroLibreta < numeroLibreta0)
                    {
                        // Mover los valores existentes hacia abajo
                        nombre2 = nombre1;
                        numeroLibreta2 = numeroLibreta1;

                        nombre1 = nombre0;
                        numeroLibreta1 = numeroLibreta0;

                        nombre0 = nombre;
                        numeroLibreta0 = nroLibreta;
                    }
                    else 
                    if (nroLibreta < numeroLibreta1)
                    {
                        nombre2 = nombre1;
                        numeroLibreta2 = numeroLibreta1;

                        nombre1 = nombre;
                        numeroLibreta1 = nroLibreta;
                    }
                    else
                    {
                        nombre2 = nombre;
                        numeroLibreta2 = nroLibreta;
                    }
                    break;
            }
            orden++;
        }

        #endregion

        #region Métodos para Imprimir en pantalla
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu de opciones");
            Console.WriteLine("1- Registrar las notas de los tres alumnos");
            Console.WriteLine("2- Mostrar lista ordenada");
            Console.WriteLine("-1 P / Salir");
            int opc = Convert.ToInt32(Console.ReadLine());
            return opc;
        }
        static void MostrarPantallaSolicitarAlumnos()
        {
            Console.Clear();
            for (int nro = 0; nro < 3;  nro++) {
                Console.WriteLine($"Ingrese el nombre del {nro+1}º alumno:");
                string nombre = Console.ReadLine();
                Console.WriteLine($"Ingrese la nota de libreta del {nro+1}º alumno:");
                int numero = Convert.ToInt32(Console.ReadLine());
                RegistrarNombreYNumeroLibreta(nombre, numero);
            }
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadKey();
        }
        static void MostrarPantallaMostrarListaOrdenada()
        {
            Console.Clear();
            Console.WriteLine("Lista Ordenada:");
            Console.WriteLine($"Nombre:{nombre0}, Número de libreta: {numeroLibreta0}");
            Console.WriteLine($"Nombre:{nombre1}, Número de libreta: {numeroLibreta1}");
            Console.WriteLine($"Nombre:{nombre2}, Número de libreta: {numeroLibreta2}");
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadKey();
        }
        #endregion

        #region Ejecución del menú
        static void Main(string[] args)
        {
            int opt = MostrarPantallaSolicitarOpcionMenu();

            while (opt != -1) {
                switch(opt) {
                    case 1:
                        MostrarPantallaSolicitarAlumnos();
                        break;
                    case 2:
                        MostrarPantallaMostrarListaOrdenada();
                        break;
                    default:
                        opt = -1;
                        break;
                }

                if (opt != -1)
                {
                    opt = MostrarPantallaSolicitarOpcionMenu();
                }
            }
        }
        #endregion
    }
}
