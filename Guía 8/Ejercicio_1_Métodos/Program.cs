namespace Ejercicio_1_Métodos
{
    internal class Program
    {

        static int contador, acumulador, ingresos, num, mayor, menor;
        
        static void InicializarVariables()
        {
            contador = 0;
            acumulador = 0;
            mayor = 0;
            menor = 0;
        }

        static void RegistrarValor()
        {
            Console.WriteLine($"Ingrese el {contador}° número:");
            num = Convert.ToInt32(Console.ReadLine());
            acumulador += num;
        }

        static void SolicitarCantidadIngresos()
        {
            Console.WriteLine("Ingrese la cantidad de ingresos:");
            ingresos = Convert.ToInt32(Console.ReadLine());
        }

        static void VerificarValorMaximo()
        {
            if (contador == 1 || num > mayor)
            {
                mayor = num;
            }
        }

        static void VerificarValorMinimo()
        {
            if (contador == 1 || num < menor)
            {
                menor = num;
            }
        }

        static double CalcularPromedio()
        {
            double promedio = 0;
            if (ingresos > 0)
            {
                promedio = (acumulador * 1.0) / (contador - 1);
                Console.WriteLine($"Mayor número: {mayor}");
                Console.WriteLine($"Menor número: {menor}");
                Console.WriteLine($"Promedio: {promedio:f2}");
            }
            else
            {
                Console.WriteLine("No hubo ingresos.");
            }
            return promedio;
        }


        static void Main(string[] args)
        {
            
            InicializarVariables();
            SolicitarCantidadIngresos();

            for (contador = 1; contador <= ingresos; contador++)
            {

                RegistrarValor();
                VerificarValorMaximo();
                VerificarValorMinimo();


            }

            CalcularPromedio();

            
        }
    }
}
