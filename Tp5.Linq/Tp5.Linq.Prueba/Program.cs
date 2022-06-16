using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Tp5.Linq.Entities;
using Tp5.Linq.Logic;

namespace Tp5.Linq.Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }

            Console.ReadLine();   
        }

        public static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Elige una opcion:");
            Console.WriteLine("1) Ejercicio 1");
            Console.WriteLine("2) Ejercicio 2");
            Console.WriteLine("3) Ejercicio 3");
            Console.WriteLine("4) Ejercicio 4");
            Console.WriteLine("5) Ejercicio 5");
            Console.WriteLine("6) Ejercicio 6");
            Console.WriteLine("7) Ejercicio 7");
            Console.WriteLine("8) Ejercicio 8");
            Console.WriteLine("9) Ejercicio 9");
            Console.WriteLine("10) Ejercicio 10");
            Console.WriteLine("11) Ejercicio 11");
            Console.WriteLine("12) Ejercicio 12");
            Console.WriteLine("13) Ejercicio 13");
            Console.WriteLine("14) Salir");
            Console.Write("\r\nSeleccione una opcion: ");

            switch (Console.ReadLine())
            {
                case "1":
                    MothodsMenu.Ejercicio1();
                    return true;
                case "2":
                    MothodsMenu.Ejercicio2(); 
                    return true;
                case "3":
                    MothodsMenu.Ejercicio3();
                    return true;
                case "4":
                    MothodsMenu.Ejercicio4();
                    return true;
                case "5":
                    MothodsMenu.Ejercicio5();
                    return true;
                case "6":
                    MothodsMenu.Ejercicio6();
                    return true;
                case "7":
                    MothodsMenu.Ejercicio8();
                    return true;
                case "8":
                    MothodsMenu.Ejercicio8();
                    return true;
                case "9":
                    MothodsMenu.Ejercicio9();
                    return true;
                case "10":
                    MothodsMenu.Ejercicio10();
                    return true;
                case "11":
                    MothodsMenu.Ejercicio8();
                    return true;
                case "12":
                    MothodsMenu.Ejercicio12();
                    return true;
                case "13":
                    MothodsMenu.Ejercicio8();
                    return true;
                case "14":
                    return false;
                default:
                    return true;
            }
        }
    }
}
