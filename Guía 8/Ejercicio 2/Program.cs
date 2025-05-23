using System.Data;
using System.Runtime.ExceptionServices;

namespace Ejercicio_2
{
    internal class Program
    {
        static int edad0, edad1, edad2, edad3, suma_edades;
        static double monto, porcentaje0, porcentaje1, porcentaje2, porcentaje3, monto0, monto1, monto2, monto3;

        static void RegistrarMontoARepartir(double monto)
        {
            Program.monto = monto;

        }

        static void RegistrarEdad(int edad, int nroNiña)
        {
            switch (nroNiña)
            {
                case 0: 
                    edad0 = edad;
                    break;
                case 1: 
                    edad1 = edad;
                    break;
                case 2: 
                    edad2 = edad; 
                    break;
                case 3: 
                    edad3 = edad; 
                    break;
            }
        }

        static void CalcularMontosYPorcentajesArepartir() {

            suma_edades = edad0 + edad1+ edad2 + edad3;

            porcentaje0 = ((double)edad0 / suma_edades) * 100;
            porcentaje1 = ((double)edad1 / suma_edades) * 100;
            porcentaje2 = ((double)edad2 / suma_edades) * 100;
            porcentaje3 = ((double)edad3 / suma_edades) * 100;


            monto0 = (porcentaje0 * monto) / 100;
            monto1 = (porcentaje1 * monto) / 100;
            monto2 = (porcentaje2 * monto) / 100;
            monto3 = (porcentaje3 * monto) / 100;
        }

        #region Métodos para imprimir pantallas
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Iniciar Monto a Repartir");
            Console.WriteLine("2 - Solicitar Edad por niña");
            Console.WriteLine("3 - Mostrar monto y porcentajes que corresponde a cada niña");
            Console.WriteLine("-1 P/Salir");
            int opt = Convert.ToInt32(Console.ReadLine());
            return opt;
        }
        static void MostrarPantallaSolicitarMontoARepartir()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el monto a repartir:");
            double monto = Convert.ToDouble(Console.ReadLine());
            RegistrarMontoARepartir(monto);

            Console.WriteLine("\nPresione una tecla para continuar:");
            Console.ReadKey();
        }
        static void MostrarPantallaSolicitarEdadesNiñas()
        {
            Console.Clear();
            Console.WriteLine("Edades de las niñas:");
            for(int n = 0; n < 4; n++) {
                Console.WriteLine($"Edad de la niña nro: {n + 1}");
                int edad = Convert.ToInt32(Console.ReadLine());
                RegistrarEdad(edad,n);
            }
        }

        static void MostrarPantallaCalcularMostrarMontoYPorcentajePorNiña()
        {
            Console.Clear();
            Console.WriteLine("Reparto de dinero: \n\n");

            CalcularMontosYPorcentajesArepartir();

            Console.WriteLine($"Niña 1 ({edad0}), Porcentaje: {porcentaje0:f2}, monto: ${monto0:f2}");
            Console.WriteLine($"Niña 2 ({edad1}), Porcentaje: {porcentaje1:f2}, monto: ${monto1:f2}");
            Console.WriteLine($"Niña 3 ({edad2}), Porcentaje: {porcentaje2:f2}, monto: ${monto2:f2}");
            Console.WriteLine($"Niña 4 ({edad3}), Porcentaje: {porcentaje3:f2}, monto: ${monto3:f2}");

            Console.WriteLine("\n\n\nPresione una tecla para volver al menú principal");
            Console.ReadKey();
        }
        #endregion

        static void Main(string[] args)
        {
            

            int op = MostrarPantallaSolicitarOpcionMenu();

            #region iterar opciones menú
            while (op != -1)
            {
                #region verificar opción
                switch (op)
                {
                    case 1:
                        MostrarPantallaSolicitarMontoARepartir();
                        break;
                    case 2:
                        MostrarPantallaSolicitarEdadesNiñas();
                        break;
                    case 3:
                        MostrarPantallaCalcularMostrarMontoYPorcentajePorNiña();
                        break;
                    default:
                        op = -1;
                        break;
                }
                #endregion

                #region solicitar opción
                if (op != -1)
                    op = MostrarPantallaSolicitarOpcionMenu();
                #endregion
            }
            #endregion
        }
    }
}
