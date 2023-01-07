using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeraApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo!");
            //comentario de linea
            /*
                Comentario de bloque
             */

            //variables
            string nombre = "Pablo";

            int numero = 1234;

            bool ingreso = false;

            double peso = 56.3;

            char letra = 'x';  //almacena solo un caracter

            const double PI = 3.1416;

            //byte --> dato numerico entero sin signo, del 0 al 255 --> 1byte
            //sbyte-- > dato numerico entero con signo, del -128 al 127 -- > 1byte
            //ushort-- > dato numerico entero sin signo, del 0 al 65553 -- > 1byte
            //short -- > dato numerico entero con signo, del -32768 al 32767 -- > 2byte

            float n1 = -14;
            float n2 = -5.2f;
            float res1 = n1 / n2;
            Console.WriteLine("float : " + res1); //salida: 2,692308 

            double n3 = -14;
            double n4 = -5.2f;
            double res2 = n3 / n4;
            Console.WriteLine("double : " + res2);//salida: 2,69230779106095 

            decimal n5 = -14;
            decimal n6 = -5.2m;
            decimal res3 = n5 / n6;
            Console.WriteLine("decimal : " + res3); //salida: 2,6923076923076923076923076923 

            //---------------------------------------------------------------

            Console.WriteLine("Desea ingresar? S/N");
            char respuesta = Console.ReadKey(true).KeyChar;

            Console.WriteLine("La opcion elegida es:" + respuesta);

            if (respuesta == 's' || respuesta == 'S') //char se usa con comillas simples
            {
                Console.WriteLine("------------Bienvenido!!!----------------");
            } else
            {
                Console.WriteLine("------------Lo esperamos la proxima vez!----------");
            }
          
            
            Console.WriteLine("Ingrese su edad: ");
            byte edad = byte.Parse(Console.ReadLine());  //uso byte porque me guarda numeros positivos del 0 al 25
            //byte.parse() me convierte cualquier cosa a byte(numero entero), ReadLine me devuelve un string

            Console.WriteLine($"Usted tiene { edad } años");
            if(edad >= 18)
            {
                Console.WriteLine("Usted es mayor de edad");
            }
            else
            {
                Console.WriteLine("Usted es menor de edad");
            }
            Console.WriteLine("Tiene hermanos? S/N");
            char hermanos = (char)Console.ReadKey(true).Key; //ReadKey me devuelve string, debo cambiarlo a char
            //(char).Console... es otra forma de transformar las variables, eso se llama "casting"
            //esto me devuelve SIEMPRE MAYUSCULAS

            if(hermanos == 'S')
            {
                Console.WriteLine("nice");
            } else
            {
                Console.WriteLine("sos hijo unico.");
            }
            Console.WriteLine("------ Fin del programa------");     

            Console.ReadKey();
        }
    }
}
