using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio__6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("L6, Esteban Lopez Escobar, 1298126");
            Console.WriteLine();
            Console.WriteLine("HOLA, bienvenido. Escriba su nombre por favor:");
            string nombre = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hola" + nombre + "Bienvenido a C#");
            Console.WriteLine();

            // Ejercicio#1
            Console.WriteLine("Ingrese un numero del 1 al 5 ");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Bicicleta");
                    Console.WriteLine("No motorizado");
                    break;

                case 2:
                    Console.WriteLine("Motocicleta");
                    Console.WriteLine("Ligero");
                    break;
                case 3:
                    Console.WriteLine("Auto");
                    Console.WriteLine("Mediano");
                    break;
                case 4:
                    Console.WriteLine("Camion");
                    Console.WriteLine("Pesado");
                    break;
                case 5:
                    Console.WriteLine("Auto bus");
                    Console.WriteLine("Transporte publico");
                    break;
                default:
                    Console.WriteLine("Numero no establecido");
                    break;

            }
            Console.WriteLine();
            // Ejercicio #2 
            Console.WriteLine("Ejercicio #2");
            Console.WriteLine();
            Console.WriteLine("Ingrese su numero de tarjeta de credito");
            int tarjeta;
            double nuevoLimite, extra = 0, limiteActual;
            Console.WriteLine();
            tarjeta = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su Limite actual: ");
            limiteActual = double.Parse(Console.ReadLine());
            switch(tarjeta)
            {
                case 1:
                    extra = 0.25;
                    break;
                case 2:
                    extra = 0.35;
                    break;
                case 3:
                    extra = 0.4;
                    break;
                default:
                    extra = 0.5;
                    break;

                   

            }
            nuevoLimite = limiteActual + (limiteActual * extra);
            Console.WriteLine("Su nuevo limite es de: " + nuevoLimite);
            // Ejercicio #3
            Console.WriteLine();
            Console.WriteLine("Ejercicio 3");
            int puntuacion;
            double aumento= 0, dineroTotal;
            Console.WriteLine("Ingrese su puntuacion en el trabajo. 1 = 0.0, 2 = 0.4 y de 3 en adelante es de 0.6");
            puntuacion = int.Parse(Console.ReadLine());
            switch (puntuacion)
            {
                case 1:
                    aumento = 0.0;
                    Console.WriteLine("Inaceptable");
                    break;
                case 2:
                    aumento = 0.4;
                    Console.WriteLine("Aceptable");
                    break;
                case 3:
                    aumento = 0.6;
                    Console.WriteLine("Meritorio");
                    break;
                default:
                    aumento = 0.6;
                    Console.WriteLine("Su aumento fue meritorio o mayor");
                    break;
            }
            Console.WriteLine();
            dineroTotal = 2.400 * aumento;
            Console.WriteLine("Su dinero total fue de: " + dineroTotal);
            Console.WriteLine();
            // Ejercicio #4
            Console.WriteLine("Ejercicio 4");
            int tipoPizza, ingredienteVegano, ingredienteNovenago;
            Console.WriteLine("Elija que tipo de pizza quiere: esta entre ingredientes veganos y no veganos. Si eleije 1 su ingrediente sera no vegano y si elije 2 sera vegano ");
            tipoPizza = int.Parse(Console.ReadLine());
            switch (tipoPizza)
            {
                case 1:
                    Console.WriteLine("Elijio una pizza no vegana");
                    Console.WriteLine("Sus ingredientes son: ");
                    Console.WriteLine("1. Peperoni");
                    Console.WriteLine("2. Jamon");
                    Console.WriteLine("3. Salmon");
                    Console.WriteLine("Elija una opcion");
                    ingredienteNovenago = int.Parse(Console.ReadLine());
                    break;
                    switch (ingredienteNovenago)
                    {
                        case 1:
                            Console.WriteLine();
                            Console.WriteLine("Elijio de peperoni");
                            break;
                        case 2:
                            Console.WriteLine("Elijio de Jamon");
                            break;
                        case 3:
                            Console.WriteLine("Elijio de salmon");
                    }
                case 2:
                    Console.WriteLine("Elijio una pizza vegana");
                    Console.WriteLine("Sus opciones son: ");
                    Console.WriteLine("1. Pimiento");
                    Console.WriteLine("2. Tofu");
                    Console.WriteLine("Elija uno de los ingredientes");
                    ingredienteVegano = int.Parse(Console.ReadLine());
                    switch (ingredienteVegano)
                    {
                        case 1:
                            Console.WriteLine("Su ingrediente fue el Pimiento");
                            break;
                        case 2:
                            Console.WriteLine("Su ingrediente fue el Tofu");
                            break;
                    }
                    break;
            }













        }
    }
}
