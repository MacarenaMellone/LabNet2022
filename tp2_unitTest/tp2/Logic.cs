using System;
using tp2.Exceptions;

namespace tp2
{
    public class Logic
    {
        public static void Comparation()
        {
            Console.WriteLine("Introduzca valor a comparar");
            int valor1;
            valor1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca valor a comparar");
            int valor2;
            valor2 = Int32.Parse(Console.ReadLine());

            OperationsExceptions.OperacionException(valor1, valor2, false); 
        }
        public static void CustomException()
        {
            try
            {
                OperationsExceptions.ThrowPersonalizedException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n");
            }
        }
    }
}
