using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2.Exceptions
{
    public class OperationsExceptions
    {
        public static void OperacionException(int x, int y, bool dividir)
        { 
            try
            {
                if (dividir)
                {
                    int division = x / y;
                    Console.WriteLine($"El resultado es {division}");
                }
                else 
                {
                    if(x >= y)
                    {
                        x -= y;
                        Console.WriteLine($"{x} es mayor a {y}");   
                    }
                    else
                    {
                        throw new ArgumentException($"{x} es menor a {y}");
                    }
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Solo Chuck Norris divide por cero!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio un error {ex.Message}");
                Console.WriteLine($"StackTrace:\n   {ex.StackTrace}");
            }
            
            finally
            {
                Console.WriteLine("Ha terminado");
            }
        }
        public static void ThrowPersonalizedException()
        {
            throw new PersonalizedException();
        }
    }
}
