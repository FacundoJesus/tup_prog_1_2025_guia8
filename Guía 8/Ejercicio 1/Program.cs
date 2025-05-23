namespace Ejercicio_1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Defino variables (Atributos)
            int contador, acumulador, ingresos, num, mayor, menor;
            double promedio;
            #endregion
            #region Proceso
            contador = 0;
            acumulador = 0;
            mayor = 0;
            menor = 0;
            Console.WriteLine("Ingrese la cantidad de ingresos:");
            ingresos = Convert.ToInt32(Console.ReadLine());
            for (contador = 1; contador <= ingresos; contador++) {
                Console.WriteLine($"Ingrese el {contador}° número:");
                num = Convert.ToInt32(Console.ReadLine());
                acumulador += num;
                if (contador == 1) {
                    mayor = num;
                    menor = num;
                }

                if (num > mayor)
                {
                    mayor = num;
                }
                else 
                if (num < menor)
                {
                    menor = num;
                }
            }
            #endregion 
            
            #region Informo
            if (ingresos > 0) {
                promedio = (acumulador * 1.0) / (contador-1);
                Console.WriteLine($"Mayor número: {mayor}");
                Console.WriteLine($"Menor número: {menor}");
                Console.WriteLine($"Promedio: {promedio:f2}");
            }
            else {
                Console.WriteLine("No hubo ingresos.");
            }
            #endregion
        }
    }
}
