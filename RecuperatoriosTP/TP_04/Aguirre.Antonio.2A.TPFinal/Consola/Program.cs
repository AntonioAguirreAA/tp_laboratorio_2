using System;
using System.Collections.Generic;
using Entidades;
using XML;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Listado<Dispositivo> listado = new Listado<Dispositivo>();
            Serializador<List<Dispositivo>> serializador = new Serializador<List<Dispositivo>>();

            List<Dispositivo> aux = new List<Dispositivo>();
 
            try
            {
                serializador.Importar(out aux);
                listado.Lista = aux;
                Console.WriteLine("Importado con exito");
            }
            catch(Exception)
            {
                Console.WriteLine("No se pudo importar");
            }
            Console.WriteLine(listado.ToString());

            Computadora c1 = new Computadora(1, "Antonio Aguirre", "No enciende", 1000, DateTime.Parse("13/12/2021"));

            listado.Modificar(c1);

            Console.WriteLine("");
            Console.WriteLine(listado.ToString());

            Listado<Dispositivo>.Procesar(c1);

            Console.WriteLine("");
            Console.WriteLine(listado.ToString());
        }
    }
}
