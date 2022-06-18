using System;
using Tp4.EF.Common;
using Tp4.EF.Entities;
using Tp4.EF.Logic;

namespace Tp4.EF.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        public static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Elige una opcion:");
            Console.WriteLine("1) Listado Categories");
            Console.WriteLine("2) Alta Categories");
            Console.WriteLine("3) Baja Categories");
            Console.WriteLine("4) Modificacion Categories");
            Console.WriteLine("5) Listado Shippers");
            Console.WriteLine("6) Alta Shippers");
            Console.WriteLine("7) Baja Shippers");
            Console.WriteLine("8) Modificacion Shippers");
            Console.WriteLine("9) Salir");
            Console.Write("\r\nSeleccione una opcion: ");

            switch (Console.ReadLine())
            {
                case "1":
                    MethodsMainMenu.GetCategories();
                    return true;
                case "2":
                    MethodsMainMenu.AddCategories();
                    return true;
                case "3":
                    MethodsMainMenu.DeleteCategories();
                    return true;
                case "4":
                    MethodsMainMenu.UpdateCategories();
                    return true;
                case "5":
                    MethodsMainMenu.GetShippers();
                    return true;
                case "6":
                    MethodsMainMenu.AddShippers();
                    return true;
                case "7":
                    MethodsMainMenu.DeleteShippers();
                    return true;
                case "8":
                    MethodsMainMenu.UpdateShippers();
                    return true;
                case "9":
                    return false;
                default:
                    return true;
            }
        }
        
    }
}