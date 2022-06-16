using System;
using System.Collections.Generic;
using System.Linq;
using Tp5.Linq.Entities;
using Tp5.Linq.Logic;

namespace Tp5.Linq.Prueba
{
    public class MothodsMenu
    {
        private static CustomersLogic customersLogic = new CustomersLogic();
        private static ProductsLogic productsLogic = new ProductsLogic();

        //1
        public static void Ejercicio1(){

            Console.Clear();
            Console.WriteLine("Ejercicio 1\n");
            Customers customers = customersLogic.CoustomerObjects("Sweden");
            Console.WriteLine($"{customers.CustomerID} {customers.CompanyName} - {customers.City} {customers.Country}");
            Console.WriteLine("\r\nPresione enter para volver al menu principal");
            Console.ReadLine();

        }
        //2
        public static void Ejercicio2(){

            Console.Clear();
            Console.WriteLine("Ejercicio 2\n");
            Console.WriteLine("Stock - Products\n");
            IEnumerable<Products> products = productsLogic.ProductsStock();
            foreach (var p in products){
                Console.WriteLine($"{p.UnitsInStock} - {p.ProductName}");
            }
            Console.WriteLine("\r\nPresione enter para volver al menu principal");
            Console.ReadLine();

        }
        //3
        public static void Ejercicio3(){

            Console.Clear();
            Console.WriteLine("Ejercicio 3\n");
            Console.WriteLine("Products - Stock  - Price \n");
            List<Products> products = productsLogic.ProdStockPrice();
            foreach (var p in products){
                Console.WriteLine($"{p.ProductName} - {p.UnitsInStock} - {p.UnitPrice} ");
            }

            Console.WriteLine("\r\nPresione enter para volver al menu principal");
            Console.ReadLine();

        }
        //4
        public static void Ejercicio4(){

            Console.Clear();
            Console.WriteLine("Ejercicio 4\n");
            Console.WriteLine("Customers - Region\n");
            List<Customers> customers = customersLogic.CustomerRegion();
            foreach (var c in customers){
                Console.WriteLine($"{c.CustomerID} - {c.Region}");
            }

            Console.WriteLine("\r\nPresione enter para volver al menu principal");
            Console.ReadLine();

        }
        //5
        public static void Ejercicio5(){

            Console.Clear();
            Console.WriteLine("Ejercicio 5\n");
            Products p = productsLogic.FirstOrNullProds();
            if (p != null){
                Console.WriteLine($"{p.ProductName}");}
            else{
                Console.WriteLine("No existe producto con ID 789");}

            Console.WriteLine("\r\nPresione enter para volver al menu principal");
            Console.ReadLine();
        }
        //6
        public static void Ejercicio6() {

            Console.Clear();
            Console.WriteLine("Ejercicio 6\n");
            Console.WriteLine("Mayuscula - Minuscula\n");
            List<Customers> customers = customersLogic.CustomerNombre();
            foreach (var c in customers){
                Console.WriteLine($"{c.ContactName.ToUpper()} - {c.ContactName.ToLower()}");
            }

            Console.WriteLine("\r\nPresione enter para volver al menu principal");
            Console.ReadLine();
        }
        //7
        public static void Ejercicio7()
        {

            Console.Clear();
            Console.WriteLine("Ejercicio 7\n");
            Console.WriteLine("Customers - Orders\n");
            var tuple = customersLogic.CustomerOrder();
            foreach (var c in tuple){
                Console.WriteLine($"{c.Item1.CustomerID} {c.Item1.CompanyName} {c.Item1.Region} - {c.Item2.OrderID} {c.Item2.OrderDate}");
            }

            Console.WriteLine("\r\nPresione enter para volver al menu principal");
            Console.ReadLine();
        }
        //8
        public static void Ejercicio8() {

            Console.Clear();
            Console.WriteLine("Ejercicio 8\n");
            Console.WriteLine("Customers - Region\n");
            IEnumerable<Customers> customers = customersLogic.CustomerRegion3();
            foreach(var c in customers){
                Console.WriteLine($"{c.CustomerID} {c.CompanyName} - {c.Region}");
            }

            Console.WriteLine("\r\nPresione enter para volver al menu principal");
            Console.ReadLine();
        }
        //9
        public static void Ejercicio9()
        {

            Console.Clear();
            Console.WriteLine("Ejercicio 9\n");
            Console.WriteLine("Products\n");
            List<Products> products = productsLogic.ProductsList();
            foreach (var p in products){
                Console.WriteLine($"{p.ProductName}");
            }

            Console.WriteLine("\r\nPresione enter para volver al menu principal");
            Console.ReadLine();

        }
        //10
        public static void Ejercicio10()
        {

            Console.Clear();
            Console.WriteLine("Ejercicio 10\n");
            Console.WriteLine("Stock - Products \n");
            List<Products> products = productsLogic.ProdsListStock();
            foreach (var p in products){
                Console.WriteLine($"{p.UnitsInStock} - {p.ProductName}");
            }

            Console.WriteLine("\r\nPresione enter para volver al menu principal");
            Console.ReadLine();

        }
        //11
        public static void Ejercicio11()
        {

            Console.Clear();
            Console.WriteLine("Ejercicio 11\n");
            Console.WriteLine("Categories asociadas\n");
            var categoriesLogic = new CategoriesLogic();
            List<Categories> categories = categoriesLogic.CategoriesProd();
            IEnumerable<Categories> noduplicadas = categories.Distinct();
            foreach (var c in noduplicadas){
                Console.WriteLine($"{c.CategoryID} - {c.CategoryName}");
            }

            Console.WriteLine("\r\nPresione enter para volver al menu principal");
            Console.ReadLine();
        }
        //12
        public static void Ejercicio12()
        {

            Console.Clear();
            Console.WriteLine("Ejercicio 12\n");
            Console.WriteLine("Product \n");
            Products p = productsLogic.FirstProduct();
            Console.WriteLine($"{p.ProductID} {p.ProductName}");

            Console.WriteLine("\r\nPresione enter para volver al menu principal");
            Console.ReadLine();

        }
        //13
        public static void Ejercicio13()
        {

            Console.Clear();
            Console.WriteLine("Ejercicio 13\n");
            Console.WriteLine("Ordenes asociadas - Customers \n");
            var tuple = customersLogic.CustomerOrdersA();
            foreach (var c in tuple){
                Console.WriteLine($"{c.Item2} - {c.Item1.CustomerID} {c.Item1.CompanyName}");
            }

            Console.WriteLine("\r\nPresione enter para volver al menu principal");
            Console.ReadLine();
        }

    }
}
