using System;
using Tp4.EF.Common;
using Tp4.EF.Entities;
using Tp4.EF.Logic;

namespace Tp4.EF.UI
{
    public class MethodsMainMenu
    {
        private static CategoriesLogic categoriesLogic = new CategoriesLogic();
        private static ShippersLogic shipperLogic = new ShippersLogic();

        public static void GetCategories()
        {

            Console.Clear();
            Console.WriteLine("Listado Categories\n");
            try
            {
                foreach (var item in categoriesLogic.GetAll()){
                    Console.WriteLine($"{item.CategoryID} - {item.CategoryName}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\r\nPresione enter para volver al menu principal");
            Console.ReadLine();
        }
        public static void AddCategories()
        {

            Console.Clear();
            Console.WriteLine("Alta Categories\n");
            try
            {
                Console.WriteLine("Introduzca Nombre Categoria");
                string valor1;
                valor1 = Console.ReadLine();
                Console.WriteLine("Introduzca Descripcion");
                string valor2;
                valor2 = Console.ReadLine();

                categoriesLogic.Add(new Categories
                {
                    CategoryName = valor1,
                    Description = valor2
                });

                foreach (var item in categoriesLogic.GetAll()){
                    Console.WriteLine($"{item.CategoryID} - {item.CategoryName} - {item.Description}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\r\nPresione enter para volver al menu principal");
            Console.ReadLine();
        }
        public static void DeleteCategories()
        {

            Console.Clear();
            Console.WriteLine("Listado Categories\n");
            try
            {
                foreach (var item in categoriesLogic.GetAll())
                {
                    Console.WriteLine($"{item.CategoryID} - {item.CategoryName}");
                }
                Console.WriteLine();

                Console.WriteLine("Introduzca ID a Eliminar");
                int valor1;
                valor1 = Int32.Parse(Console.ReadLine());
                categoriesLogic.Delete(valor1);
                foreach (var item in categoriesLogic.GetAll())
                {
                    Console.WriteLine($"{item.CategoryID} - {item.CategoryName}");
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                CustomException customException = new CustomException();
                Console.WriteLine(customException);
            }

            Console.WriteLine("\r\nPresione enter para volver al menu principal");
            Console.ReadLine();
        }
        public static void UpdateCategories()
        {

            Console.Clear();
            Console.WriteLine("Modificacion Categories\n");

            try
            {
                foreach (var item in categoriesLogic.GetAll()){
                    Console.WriteLine($"{item.CategoryID} - {item.CategoryName} - {item.Description}");
                }
                Console.WriteLine();
                Console.WriteLine("Introduzca ID a Modificar");
                int valor1;
                valor1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca Nuevo Nombre de la Categoria");
                string valor2;
                valor2 = Console.ReadLine();
                Console.WriteLine("Introduzca Nueva Descripcion");
                string valor3;
                valor3 = Console.ReadLine();

                categoriesLogic.Update(new Categories{
                    CategoryID = valor1,
                    CategoryName = valor2,
                    Description = valor3
                });

                Console.WriteLine();
                foreach (var item in categoriesLogic.GetAll()){
                    Console.WriteLine($"{item.CategoryID} - {item.CategoryName} - {item.Description}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\r\nPresione enter para volver al menu principal");
            Console.ReadLine();
        }
        public static void GetShippers()
        {

            Console.Clear();
            Console.WriteLine("Listado Shippers\n");
            try
            {
                foreach (var item in shipperLogic.GetAll()){
                    Console.WriteLine($"{item.ShipperID} - {item.CompanyName} - {item.Phone}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("\r\nPresione enter para volver al menu principal");
            Console.ReadLine();
        }
        public static void AddShippers()
        {

            Console.Clear();
            Console.WriteLine("Alta Shippers\n");
            try
            {
                Console.WriteLine("Introduzca Nombre de la Compañia");
                string valor1;
                valor1 = Console.ReadLine();
                Console.WriteLine("Introduzca Telefono");
                string valor2;
                valor2 = Console.ReadLine();

                shipperLogic.Add(new Shippers{
                    CompanyName = valor1,
                    Phone = valor2
                });

                foreach (var item in shipperLogic.GetAll()){
                    Console.WriteLine($"{item.ShipperID} - {item.CompanyName} - {item.Phone}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("\r\nPresione enter para volver al menu principal");
            Console.ReadLine();
        }
        public static void DeleteShippers()
        {

            Console.Clear();
            Console.WriteLine("Baja Shippers\n");
            try
            {
                foreach (var item in shipperLogic.GetAll()){
                    Console.WriteLine($"{item.ShipperID} - {item.CompanyName} - {item.Phone}");
                }
                Console.WriteLine();
                Console.WriteLine("Introduzca ID a Eliminar");
                int valor1;
                valor1 = Int32.Parse(Console.ReadLine());
                shipperLogic.Delete(valor1);
                Console.WriteLine();
                foreach (var item in shipperLogic.GetAll()){
                    Console.WriteLine($"{item.ShipperID} - {item.CompanyName} - {item.Phone}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Write("\r\nPresione enter para volver al menu principal");
            Console.ReadLine();
        }
        public static void UpdateShippers()
        {

            Console.Clear();
            Console.WriteLine("Modificacion Shippers\n");
            try
            {
                foreach (var item in shipperLogic.GetAll()){
                    Console.WriteLine($"{item.ShipperID} - {item.CompanyName} - {item.Phone}");
                }
                Console.WriteLine();
                Console.WriteLine("Introduzca ID a Modificar");
                int valor1;
                valor1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca Nuevo Nombre de la Compañia");
                string valor2;
                valor2 = Console.ReadLine();
                Console.WriteLine("Introduzca Nuevo Telefono");
                string valor3;
                valor3 = Console.ReadLine();

                shipperLogic.Update(new Shippers{
                    ShipperID = valor1,
                    CompanyName = valor2,
                    Phone = valor3
                });

                Console.WriteLine();
                foreach (var item in shipperLogic.GetAll()){
                    Console.WriteLine($"{item.ShipperID} - {item.CompanyName} - {item.Phone}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\r\nPresione enter para volver al menu principal");
            Console.ReadLine();
        }
    }
}
