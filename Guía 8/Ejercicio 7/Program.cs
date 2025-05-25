namespace Ejercicio_7
{
    internal class Program
    {
        #region Atributos de la clase Program
        static int cantidad1;
        static int cantidad2;
        static int cantidad3;
        static int cantidad4;
        static int cantidad5;
        static int contadorDeTransacciones;
        static int numeroTransaccionMayor;
        static double montoTransaccionMayor;
        static double porcentajeCantidadRubro1;
        static double porcentajeCantidadRubro2;
        static double porcentajeCantidadRubro3;
        static double porcentajeCantidadRubro4;
        static double porcentajeCantidadRubro5;
        static double recaudacionTotal;
        static double mayorMonto;
        #endregion


        #region Métodos de proceso
        static void InicializarVariables()
        {
            cantidad1 = 0;
            cantidad2 = 0;
            cantidad3 = 0;
            cantidad4 = 0;
            cantidad5 = 0;
            contadorDeTransacciones = 0;
            recaudacionTotal = 0;
            mayorMonto = 0;
        }
        static void EvaluarTransaccionPuntoDeVenta(int nroTransaccion, int rubro, int cantidad, double monto)
        {
            recaudacionTotal += monto;
            //Asigno en la 1° iteracion al numero de transaccion con mayor monto;
            if ( contadorDeTransacciones == 1 || monto > mayorMonto) {
                numeroTransaccionMayor = nroTransaccion;
                mayorMonto = monto;
            }
            switch (rubro)
            {
                case 1:
                    cantidad1 += cantidad;
                    break;
                case 2:
                    cantidad2 += cantidad;
                    break;
                case 3:
                    cantidad3 += cantidad;
                    break;
                case 4:
                    cantidad4 += cantidad;
                    break;
                case 5:
                    cantidad5 += cantidad;
                    break;
                default:
                    Console.WriteLine("Rubro no válido");
                    break;
            }
            if (rubro > 0 && rubro < 6)
            {
                contadorDeTransacciones++;
            }
            
        }
        static void CalcularPorcentajesCantidadVentasPorRubro()
        {
            int cantidadTotal = cantidad1 + cantidad2 + cantidad3 + cantidad4 + cantidad5;
            if (contadorDeTransacciones > 0)
            {
                porcentajeCantidadRubro1 = (cantidad1 * 1.0 / cantidadTotal) * 100;
                porcentajeCantidadRubro2 = (cantidad2 * 1.0 / cantidadTotal) * 100;
                porcentajeCantidadRubro3 = (cantidad3 * 1.0 / cantidadTotal) * 100;
                porcentajeCantidadRubro4 = (cantidad4 * 1.0 / cantidadTotal) * 100;
                porcentajeCantidadRubro5 = (cantidad5 * 1.0 / cantidadTotal) * 100;
            }
            else
            {
                Console.WriteLine("No se han registrado transacciones!");
            }
        }
        #endregion

        #region Métodos de imprimir pantalla
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();

            Console.WriteLine("---MENU---");
            Console.WriteLine("1 - Ingresar un resumen de venta");
            Console.WriteLine("2 - Mostrar Número de transacción registrado con el mayor monto total");
            Console.WriteLine("3 - Mostrar porcentaje en cantidad de ventas por rubro");
            Console.WriteLine("4 - Mostrar recaudación por rubro y recaudación total.");
            Console.WriteLine("-1 Para SALIR del Programa");
            int opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;

        }
        static void MostrarPantallaRegistrarTransaccion()
        {
            Console.Clear();

            Console.WriteLine("Ingrese el N° DE VENTA: (-1 P/Salir)");
            int nVenta = Convert.ToInt32(Console.ReadLine());

            InicializarVariables();
            while (nVenta != -1) {
                Console.WriteLine("Ingrese el N° DE RUBRO: 1 / 2 / 3 / 4 / 5");
                int nRubro = Convert.ToInt32(Console.ReadLine());

                if (nRubro > 0 && nRubro < 6) {
                    Console.WriteLine("Ingrese la cantidad de productos vendidos:");
                    int cantProductos = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el Monto total del rubro:");
                    double montoRubro = Convert.ToDouble(Console.ReadLine());
                    EvaluarTransaccionPuntoDeVenta(nVenta, nRubro, cantProductos, montoRubro);
                }
                else
                {
                    Console.WriteLine("N° de Rubro no válido");
                }
            
                Console.WriteLine("Ingrese el N° DE VENTA: (-1 P/Salir)");
                nVenta = Convert.ToInt32(Console.ReadLine());
            }
            CalcularPorcentajesCantidadVentasPorRubro();
        }
        static void MostrarPantallaPorcentajeDeCantidadesPorRubro()
        {
            Console.Clear();

            Console.WriteLine($"Cantidad de productos vendidos del Rubro 1: {cantidad1} // Porcentaje en cantidad Rubro 1: {porcentajeCantidadRubro1:f2}%");
            Console.WriteLine($"Cantidad de productos vendidos del Rubro 2: {cantidad2} // Porcentaje en cantidad Rubro 2: {porcentajeCantidadRubro2:f2}%");
            Console.WriteLine($"Cantidad de productos vendidos del Rubro 3: {cantidad3} // Porcentaje en cantidad Rubro 3: {porcentajeCantidadRubro3:f2}%");
            Console.WriteLine($"Cantidad de productos vendidos del Rubro 4: {cantidad4} // Porcentaje en cantidad Rubro 4: {porcentajeCantidadRubro4:f2}%");
            Console.WriteLine($"Cantidad de productos vendidos del Rubro 5: {cantidad5} // Porcentaje en cantidad Rubro 5: {porcentajeCantidadRubro5:f2}%");

            Console.WriteLine("\nPresione Enter para continuar.");
            Console.ReadKey();
        }
        static void MostrarPantallaTransaccionMayorMonto()
        {
            Console.Clear();

            if (contadorDeTransacciones > 0)
            {
                Console.WriteLine($"N° de VENTA con Mayor Monto: {numeroTransaccionMayor}, Monto: {mayorMonto:c2}");
            }
            else
            {
                Console.WriteLine("No hubo ventas.");
            }

            Console.WriteLine("\nPresione Enter para continuar.");
            Console.ReadKey();
        }
        static void MostrarPantallaMontoRecaudadoTotal()
        {
            Console.Clear();

            
            Console.WriteLine($"Recaudación Total: {recaudacionTotal:c2}");
            
            Console.WriteLine("\nPresione Enter para continuar.");
            Console.ReadKey();
        }
        #endregion

        #region Menu
        static void Main(string[] args)
        {
            int opcion = MostrarPantallaSolicitarOpcionMenu();
            while (opcion != -1)
            {
                switch(opcion) {
                    case 1:
                        MostrarPantallaRegistrarTransaccion();
                        break;
                    case 2:
                        MostrarPantallaTransaccionMayorMonto();
                        break;
                    case 3:
                        MostrarPantallaPorcentajeDeCantidadesPorRubro();
                        break;
                    case 4:
                        MostrarPantallaMontoRecaudadoTotal();
                        break;
                    default:
                        opcion = -1;
                            break;
                }

                if (opcion != -1) {
                   opcion =  MostrarPantallaSolicitarOpcionMenu();
                }

            }
        }
        #endregion
    }
}
