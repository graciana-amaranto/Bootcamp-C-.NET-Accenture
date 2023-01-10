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

            double peso_ej = 56.3;

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
            //puedo ponerlo como uint peso = UInt32.Parse(Console.ReadLine());

            Console.WriteLine($"Usted tiene { edad } años");
            if(edad >= 18)
            {
                Console.WriteLine("Usted es mayor de edad");
            }
            else
            {
                Console.WriteLine("Usted es menor de edad");
            }

            //operador ternario
            //condicion ? (condicion == true) : (condicion == false)
            Console.WriteLine(edad >= 18 ? "sos mayor de edad" : "sos menor de edad"); 


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

            //objeto date
            DateTime fyh = DateTime.Now;
            Console.WriteLine($"La fecha y hora actual es: {fyh} ");
            Console.WriteLine($"fyh.year: {fyh.Year}");
            Console.WriteLine($"fyh.Month: {fyh.Month}");
            Console.WriteLine($"fyh.Day: {fyh.Day}");
            Console.WriteLine($"fyh.DayOfYear: {fyh.DayOfYear}"); //del 1 al 365

            Console.WriteLine($"fyh.DayOfYear -> nombre: {fyh.DayOfWeek} - numero: {(int)fyh.DayOfWeek}");

            //----------------------------- Bucles----------------------------
            Console.WriteLine("\n Representar los numeros del 0 al 20 de 2 en 2 con for:");
            for (int num = 0; num<=20; num += 2)
            {
                Console.WriteLine(num);
            }
            //matrices
            Console.WriteLine("Multiples valores en los campos:");
            for (int i=0, j=9; i<10; i++, j--)
            {
                Console.WriteLine($"i: {i} - j: {j}");
            }

            Console.WriteLine("\nMostrar por consola 10 numeros aleatorios entre el 1 y el 20 con do while:");
            var rnd = new Random(); //tipado dinamico fuerte
            int inc = 0;
            do
            {
                int random = rnd.Next(1,20); //1,20 es el intervalo especificado
                Console.WriteLine(random);
                inc++;
            } while(inc < 10);


            Console.WriteLine("\nCalcular el promedio de notas de alumnos con do while");

            do
            {
                float sumatoria = 0;
                int cantidad = 0;
                string notas = "";

                Console.WriteLine("Ingrese el nombre del alumno:");
                string nombre_alum = Console.ReadLine();

                do
                {
                    Console.WriteLine($"Ingrese las notas del alumno {nombre_alum}, f para terminar.");
                    string entrada = Console.ReadLine();
                    if (entrada == "f") break;//uso doble comillas porque no es char, es string

                    try
                    {
                        float nota = float.Parse(entrada);
                        if (nota >= 0 && nota <= 10){
                
                            cantidad++;
                            sumatoria+= nota;
                            notas += (nota + ", "); //para ir concatenando todas las notas y mostrar la lista de notas
                        }
                        else
                        {
                            Console.WriteLine($"Nota {nota} no valida.");
                        }
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine($"Entrada {entrada} no se puede convertir a decimal. \nDescripcion del error:{ex} ");
                    }
                
                 } while (true);

                if (cantidad > 0)
                {
                   float promedio = sumatoria / cantidad;
                    Console.WriteLine($"El promedio de las notas ingresadas es: {promedio}, y la cantidad de notas es: {cantidad}." +
                        $"\nLas notas ingresadas son: {notas}. \n" +
                        $"El alumno {nombre_alum} {(promedio >=4 ? "Aprobo" : "Desaprobo")}");
                }
                else
                {
                    Console.WriteLine("No hay notas ingresadas.");
                }

                Console.WriteLine("Desea calcular otro promedio? (S/N)");

            } while(Console.ReadLine() != "n");  //empieza un nuevo bucle con otro alumno.

            Console.WriteLine("------ Fin del programa------");
        }
    }
}
