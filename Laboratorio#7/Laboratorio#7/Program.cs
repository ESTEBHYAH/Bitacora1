using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esteban Lopez Escobar, Carnet: 1298126");
            Console.WriteLine("Laboratorio#7, bienvenido a c#");
            // Ejercicio#1
            Console.WriteLine();
            Console.WriteLine("Ejercicio#1");
            Console.WriteLine();
            int N, suma = 0;
            double promedio = 0;
            Console.WriteLine("Ingrese cuantos numeros desea sumar");
            N = int.Parse(Console.ReadLine());
            int cont = 0;
            while (N <= 0)
            {
                Console.WriteLine("Ingrese otro numero");
                N = int.Parse(Console.ReadLine());
            }



                while (cont <= N)
                {
                    suma = suma + cont;
                    cont++;
                }
            
            Console.WriteLine("Su suma fue " + suma);
            Console.WriteLine();
            promedio = suma / N;
            Console.WriteLine("Su promedio fue de: " + promedio);
            // Ejercicio #2
            Console.WriteLine("Ejercicio#2");
            Console.WriteLine();
            double grados, num, kilometrs, millas;
            double Faren = 0, Cels = 0, Millas = 0;
            do
            {
                Console.WriteLine("Cual quiere decidir: ");
                Console.WriteLine();
                Console.WriteLine("1.Convertir Celsius a Fahrenheit. 2.Convertir Fahrenheit a Celsius. 3.Convertir Kilómetros a Millas. 4.Salir ");
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Ingrese sus grados Celsius: ");
                        grados = int.Parse(Console.ReadLine());
                        Faren = (grados * 9) / 5 + 32;
                        Console.WriteLine(Faren.ToString("F2"));
                        break;
                    case 2:
                        Console.WriteLine("Ingrese sus grados Fahrenheit");
                        grados = int.Parse(Console.ReadLine());
                        Cels = (grados - 32) * 5 / 9;
                        Console.WriteLine("Sus grados son: " + Cels);
                        break;
                    case 3:
                        Console.WriteLine("Ingrese sus kilometros");
                        kilometrs = int.Parse(Console.ReadLine());
                        Millas = kilometrs / 1.609;
                        Console.WriteLine("Sus millas son: " + Millas);
                        break;
                        
                        

                }
            } while (num !=4);
            // Ejercicio#3
            Console.WriteLine("Ejercicio #3");
            Console.WriteLine();
            Random random = new Random();
            int numeroSecreto = random.Next(1, 100);
            int numero = 0;
            int contador = 0;
            while (numero != numeroSecreto)
            {
                Console.Write("Adivina el número (1-100): ");
                numero = int.Parse(Console.ReadLine());

                if (numero < 1 || numero > 100)
                {
                    Console.WriteLine("Número fuera de rango. Intenta otra vez.");
                    continue; // no cuenta el intento
                }

                contador++;

                if (numero < numeroSecreto)
                {
                    Console.WriteLine("Más alto");
                }
                else if (numero > numeroSecreto)
                {
                    Console.WriteLine("Más bajo");
                }
            }

            Console.WriteLine("¡Correcto!");
            Console.WriteLine("Intentos: " + contador);
            // Ejericicio #4
            Console.ReadLine();
            int pin, contad = 0;
            do
            {
                Console.WriteLine("Ingrese su Pin");
                contad++;
                pin = int.Parse(Console.ReadLine());
                if (pin == 1234)
                {
                    Console.WriteLine("Acesso permitido");
                }
                else
                {
                    Console.WriteLine("Acesso denegado");
                }
            } while (contad <= 3 || pin == 1234);
            if (contad == 3)
            {
                Console.WriteLine();
                Console.WriteLine("Cuenta bloqueada");
            }


        }
    }
}
