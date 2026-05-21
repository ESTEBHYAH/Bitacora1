using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio#01
            Console.WriteLine("Ejercicio#01");
            Console.WriteLine("Ingrese un numero entero");
            int num;
            num = int.Parse(Console.ReadLine());
            int resultado = sumarDigitos(num);
            Console.WriteLine("Su suma final es de: " + resultado);
            Console.WriteLine();
            //Ejercicio#02
            Console.WriteLine("Ejercicio#02");
            Console.WriteLine("Ingresar un numero");
            int num2;
            num2 = int.Parse(Console.ReadLine());
            int cuadrado = Cuadrado(num2);
            Console.WriteLine("El cuadrado es " + cuadrado);
            //Ejercicio#03
            Console.WriteLine("Ejercicio#03");
            int precio;
            Console.WriteLine("Ingrese el precio del producto");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el descuento");
            double descuento;
            descuento = double.Parse(Console.ReadLine());
            double resultado2 = descuentoAplicado(precio, descuento);
            Console.WriteLine("El descuento es de " + resultado2);
            //Ejercicio#04
            Console.WriteLine("Ejercicio#04");
            Console.WriteLine("Ingrese la energia de su jugador");
            int energiaJugador;
            energiaJugador = int.Parse(Console.ReadLine());
            while (energiaJugador < 0)
            {
                Console.WriteLine("La energia no puede ser 0 coloque otra por favor");
                energiaJugador = int.Parse(Console.ReadLine());
            }
            int energiaRestante = energiaRestar(energiaJugador);
            Console.WriteLine("Su energia restante es de " + energiaRestante);
            //Ejercicio 4.2
            Console.WriteLine("Ejercicio#04.02");
            int energiaExtra = EnergiaSumar(energiaJugador);
            Console.WriteLine("Su energia nueva es de " + energiaExtra);
            //Ejercicio 4.3
            Console.WriteLine("Ejercicio#4.3");
            string nivel = estado(energiaExtra);
            Console.WriteLine("Su estado es " + nivel);
            //Ejercicio 4.4
            Console.WriteLine("Ejercicio#04.4");
            string clasificacion;
            clasificacion = clasifica(energiaExtra);
            Console.WriteLine("Su clasificacion es de " + clasificacion);
        }
        static int sumarDigitos(int a)
        {
            int suma = 0;
            while (a != 0)
            {
                suma += a % 10;
                a = a / 10;
            }
            return suma;
        }
        static int Cuadrado(int b)
        {
            int resultado = 0;
            resultado = b * b;
            return resultado;
        }
        static double descuentoAplicado(int a, double b)
        {
            double descuento = 0, resultado = 0;
            descuento = a * b;
            resultado = a - descuento;
            return resultado;
        }
        static int energiaRestar(int a)
        {
            int resultado = 0;
            resultado = a - 4;
            return resultado;
        }
        static int EnergiaSumar(int a)
        {
            int resultado = 0;
            resultado = a + 6;
            while (resultado > 20)
            {
                Console.WriteLine("No se puede ser mayor a 20 por favor cambie el valor de la energia");
                a = int.Parse(Console.ReadLine());
                resultado = a + 6;
            }
            return resultado;
        }
        static string estado(int a)
        {
            string resultado;
            if (a > 15 && a < 20)
            {
                resultado = "Alto";
            }
            else if (a > 8 && a < 14)
            {
                resultado = "Media";
            }
            else
            {
                resultado = "Bajo";
            }
            return resultado;
        }
        static string clasifica(int a)
        {
            string clasificacion;
            if (a == 20)
            {
                clasificacion = "S";
            }
            else if (a > 15 && a < 19)
            {
                clasificacion = "A";
            }
            else if (a > 8 && a < 14)
            {
                clasificacion = "B";
            }
            else
            {
                clasificacion = "C";
            }
            return clasificacion;
        }
       
    }
}
