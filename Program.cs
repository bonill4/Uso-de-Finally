using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoFinally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*El uso de "finally" va enfocada en BBDD y Lectura de ficheros externos para 
              liberar recursos 
             "finally" se ejecutara siempre sin inportar si entra en el "try" o "catch"
             */
            System.IO.StreamReader archivo = null;

            try
            {
                string linea;

                int contador = 0;

                string path = @"C:\Users\willi\source\repos\UsoFinally\Saludo.txt";

                archivo = new System.IO.StreamReader(path);

                while ((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    contador++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de lectura de archivo");
            }
            finally
            {
                if (archivo != null) archivo.Close();

                Console.WriteLine("Conexion cerrada");
            }
        }
    }
}
