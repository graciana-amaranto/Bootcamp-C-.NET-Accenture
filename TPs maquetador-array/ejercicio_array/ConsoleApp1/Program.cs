using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_array
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            do
            {
                Console.WriteLine("Ingrese los datos de la inflación mes a mes separado por espacios y presione enter:");
                string[] entrada = new string[12];

                entrada = Console.ReadLine().Split(' ');

                float[] datos = new float[entrada.Length];
                string[] meses = { "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre" };

                if (entrada.Length == 12)
                {
                    //convierto los valores a float:
                    for (int i = 0; i < datos.Length; i++)
                    {
                        Console.WriteLine($"La inflación del mes {meses[i]} es de: {entrada[i]}");
                        try { datos[i] = float.Parse(entrada[i]); }
                        catch
                        {
                            Console.Write($"El valor {entrada[i]} que ingresaste no es válido.");
                            datos[i] = 0;
                        }
                    }

                    float sumatoria = 0;
                    float cantidad = datos.Length;
                    float minimo = datos[0];
                    string minMes = meses[0];

                    float maximo = datos[0];
                    string maxMes = meses[0];

                    for (int i = 0; i < datos.Length; i++)
                    {
                        float dato = datos[i];
                        string mes = meses[i];

                        sumatoria += dato;

                        if (dato < minimo)
                        {

                            minimo = dato;
                            minMes = mes;
                        }

                        if (dato > maximo)
                        {

                            maximo = dato;
                            maxMes = mes;
                        }
                    }
                    float promedio = (float)sumatoria / cantidad;

                    //Resultados:
                    Console.WriteLine($"\nLa inflación total del año fue de: {sumatoria} ");

                    Console.WriteLine($"\nEl promedio de la inflación anual es de: {promedio}");

                    Console.WriteLine($"\nEl mes con menor inflación fue: {minMes}, con una inflación de: {minimo}");
                    Console.WriteLine($"\nEl mes con mayor inflación fue: {maxMes}, con una inflación de: {maximo}");

                    Console.WriteLine($"\n-------------------Fin del programa --------------------");
                }
                else
                {
                    Console.WriteLine("Debe ingresar los datos de inflación de todos los meses del año.");
                }
                
            Console.WriteLine("¿Desea comenzar de nuevo? S/N");
            }
            while (Console.ReadLine() != "n");
            Console.WriteLine($"\n-------------------Fin del programa --------------------");
        }
    }
}
