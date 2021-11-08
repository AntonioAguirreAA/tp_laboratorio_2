using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exepciones;

namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            try 
            {
                Console.WriteLine("Ingrese un numero:");
                string numero = Console.ReadLine();
                if (numero == "")
                {
                    throw new CamposVaciosException();
                }
                Console.WriteLine(numero);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: {0}",e.Message);
            }
            Console.ReadKey();
        }
    }
}
