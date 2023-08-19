using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //Declaracion de variables de texto capturando desde la terminal
            string? nombre;
            string? apellido;

            //Declaracion de variables de texto desde codigo
            string? codigo_estudiantil = "u20230258";
            string? becado = "Si";

            //Declaracion de variables de tipo enteras capturando desde la terminal
            int edad;

            //Declaracion de variables de tipo enteras desde codigo
            int AñoIngreso = 2023;
            int AñoEgreso = 2025;

            //Declaracion de variables decimales double capturando desde la terminal
            double mensualidad;

            //Declaraion de variables decimales desde codigo
            double transporte = 1.15;
            double alimentacion = 4.25;

            //Declaracion de variable de tiempo o time
            DateTime FechaActual = DateTime.Now;
            DateTime FechaEspecifica = new DateTime(23, 8, 19, 16, 20,00);

            //Obtencion de datos desde la terminal
            Console.WriteLine("Ingrese su nombre:");
            nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Ingrese su apellido:");
            apellido = Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese su edad:");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese su mensualidad universitaria:");
            mensualidad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();


            //Impresion de datos
            Console.WriteLine("********************Fin de impresion**************");
            Console.WriteLine("Su nombre: " + nombre);
            Console.WriteLine("Su apellido es: " + apellido);
            Console.WriteLine("Su codigo estudiantil es: " + codigo_estudiantil);
            Console.WriteLine("Es becado? " + becado);
            Console.WriteLine("Su edad es: " + edad);
            Console.WriteLine("Su año de ingreso es: " + AñoIngreso);
            Console.WriteLine("Su año de egreso es: " + AñoEgreso);
            Console.WriteLine("Su mensualidad universitaria es: " + "$" + mensualidad);
            Console.WriteLine("Su gasto diario de transporte es: " + "$" + transporte);
            Console.WriteLine("Su gasto diario de alimentacion es: " + "$" + alimentacion);
            Console.WriteLine("La fecha y tiempo de impresion de datos es: " + FechaActual);
            Console.WriteLine("La fecha que termina la practica es: " + FechaEspecifica);
            Console.WriteLine("********************Fin de impresion**************");

            Console.WriteLine("********************Inicion de impresion**************");
            //Aplicacion de funciones de cadena

            //Funcion de comparacion cadenas de texto
            bool cadenaComparativa = nombre == apellido;

            //Funcion de Minuscula
            string? funcionMinuscula1 = nombre.ToLower();
            string? funcionMinuscula2 = apellido.ToUpper();

            //Funcion de Mayuscula
            string? funcionMayuscula1 = nombre.ToLower();
            string? funcionMayuscula2 = apellido.ToUpper();

            //Funcion de Concatenado
            




            
        }
    }
}