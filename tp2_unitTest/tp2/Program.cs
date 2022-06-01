using System;
using tp2.Exceptions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                try
                {
                    Console.WriteLine("Bienvenidos \n");
                    Console.WriteLine("1. Ejercicio 1");
                    Console.WriteLine("2. Ejercicio 2");
                    Console.WriteLine("3. Ejercicio 3");
                    Console.WriteLine("4. Ejercicio 4");
                    Console.WriteLine("5. Salir");
                    Console.WriteLine("Elige una de las opciones");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Introduzca valor a dividir");
                            int valor;
                            valor = Int32.Parse(Console.ReadLine());
                            OperationsExceptions.OperacionException(valor, 0, true);
                            Console.WriteLine("Presione cualquier tecla para volver al menu principal");
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Introduzca dividendo");
                            int valor1;
                            valor1 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Introduzca divisor");
                            int valor2;
                            valor2 = Int32.Parse(Console.ReadLine());
                            OperationsExceptions.OperacionException(valor1, valor2, true);
                            Console.WriteLine("Presione cualquier tecla para volver al menu principal");
                            Console.ReadLine();
                            break;
                        case 3:
                            Logic.Comparation();
                            Console.WriteLine("Presione cualquier tecla para volver al menu principal");
                            Console.ReadLine();
                            break;
                        case 4:
                            Logic.CustomException();
                            Console.WriteLine("Presione cualquier tecla para volver al menu principal");
                            Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Ha salido de la aplicacion");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Elige una opcion entre 1 y 5");
                            break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Seguro Ingreso una letra o no ingreso nada!");
                    Console.ReadLine();
                }
            } 
            Console.ReadLine();
        }
    }
}
