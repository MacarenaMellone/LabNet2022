using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1Poo
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {

                try
                {

                    Console.WriteLine("Bienvenidos \n");
                    Console.WriteLine("1. Omnibus");
                    Console.WriteLine("2. Taxis");
                    Console.WriteLine("3. Salir");
                    Console.WriteLine("Elige una de las opciones");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {

                        case 1:
                            Console.WriteLine("1. Introducir cantidad de pasajeros");
                            Console.WriteLine("2. Salir");
                            Console.WriteLine("Elige una de las opciones");
                            int omnibus = Convert.ToInt32(Console.ReadLine());
                                switch (omnibus) 
                                {
                                    case 1:
                                        Console.WriteLine("Introduzca cantidad de pasajeros Omnibus1");
                                        int cantidad1;
                                        cantidad1 = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Introduzca cantidad de pasajeros Omnibus2");
                                        int cantidad2;
                                        cantidad2 = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Introduzca cantidad de pasajeros Omnibus3");
                                        int cantidad3;
                                        cantidad3 = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Introduzca cantidad de pasajeros Omnibus4");
                                        int cantidad4;
                                        cantidad4 = Int32.Parse(Console.ReadLine());
                                        Console.WriteLine("Introduzca cantidad de pasajeros Omnibus5");
                                        int cantidad5;
                                        cantidad5 = Int32.Parse(Console.ReadLine());
                                        List<TransportePublico> transportes = new List<TransportePublico>
                                        {
                                           new Omnibus(cantidad1),
                                           new Omnibus(cantidad2),
                                           new Omnibus(cantidad3),
                                           new Omnibus(cantidad4),
                                           new Omnibus(cantidad5)
                                        };
                                        foreach (var item in transportes)
                                        {
                                            Console.WriteLine(item.Avanzar());
                                        }
                                        Console.WriteLine("Presione cualquier tecla para volver al menu principal");
                                        Console.ReadLine();
                                        break;
                                    case 2:
                                        Console.WriteLine("Ha salido de la aplicación");
                                        salir = true;
                                        break;
                                    default:
                                        Console.WriteLine("Elige una opción entre 1 y 3");
                                        break;

                                }
                                break;

                        case 2:
                            Console.WriteLine("1. Introducir cantidad de pasajeros");
                            Console.WriteLine("2. Salir");
                            Console.WriteLine("Elige una de las opciones");
                            int taxi = Convert.ToInt32(Console.ReadLine());
                            switch (taxi)
                            {
                                case 1:
                                    Console.WriteLine("Introduzca cantidad de pasajeros Taxi1");
                                    int cantidad1;
                                    cantidad1 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Introduzca cantidad de pasajeros Taxi2");
                                    int cantidad2;
                                    cantidad2 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Introduzca cantidad de pasajeros Taxi3");
                                    int cantidad3;
                                    cantidad3 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Introduzca cantidad de pasajeros Taxi4");
                                    int cantidad4;
                                    cantidad4 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Introduzca cantidad de pasajeros Taxi5");
                                    int cantidad5;
                                    cantidad5 = Int32.Parse(Console.ReadLine());
                                    List<TransportePublico> transportes = new List<TransportePublico>
                                        {
                                           new Taxi(cantidad1),
                                           new Taxi(cantidad2),
                                           new Taxi(cantidad3),
                                           new Taxi(cantidad4),
                                           new Taxi(cantidad5)
                                        };
                                    foreach (var item in transportes)
                                    {
                                        Console.WriteLine(item.Avanzar());
                                    }
                                    Console.WriteLine("Presione cualquier tecla para volver al menu principal");
                                    Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Ha salido de la aplicación");
                                    salir = true;
                                    break;
                                default:
                                    Console.WriteLine("Elige una opción entre 1 y 3");
                                    break;

                            }
                            break;
                        case 3:
                            Console.WriteLine("Ha salido de la aplicación");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Elige una opción entre 1 y 3");
                            break;
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine("Ha ocurrido un error",e);
                }
            }

            Console.ReadLine();
        }
    }
}
