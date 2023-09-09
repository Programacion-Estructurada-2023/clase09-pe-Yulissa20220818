using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("\n----------PROGRAMACION DE CALIFICACIONES--------\n");
            Console.WriteLine("Ingresar la calificacion: ");
            double calificacion = Convert.ToDouble(Console.ReadLine());

            if (calificacion >= 10.0){
                Console.WriteLine("La nota "+ "es Excelente");
            }
            else if (calificacion > 8.0){
                Console.WriteLine("La nota "+ "es Muy Buena");
            }
            else if (calificacion >7.5){
                Console.WriteLine("La nota "+ "es Buena");
            }
            else{
                Console.Write("La nota obtenida de Deficiente");
            }
            Console.WriteLine("\n----FIN DE PROGRAMACION DE CALIFICACIONES-----\n");
        }
    }
}