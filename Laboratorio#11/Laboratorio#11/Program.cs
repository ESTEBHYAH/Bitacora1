using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicios#01
            Console.WriteLine("Ejercicio#01");
            Console.WriteLine("Ingrese una contraseña:");
            string pass = Console.ReadLine();

            bool tieneMayus = false;
            bool tieneNumero = false;
            bool tieneEspecial = false;

            if (pass.Length >= 8)
            {
                foreach (char c in pass)
                {
                    if (char.IsUpper(c)) tieneMayus = true;
                    else if (char.IsDigit(c)) tieneNumero = true;
                    else if (!char.IsLetterOrDigit(c)) tieneEspecial = true;
                }

                if (tieneMayus && tieneNumero && tieneEspecial)
                {
                    Console.WriteLine("Contraseña válida");
                }
                else
                {
                    Console.Write("Inválida: ");
                    if (!tieneMayus) Console.Write("falta mayúscula ");
                    if (!tieneNumero) Console.Write("falta número ");
                    if (!tieneEspecial) Console.Write("falta carácter especial ");
                }
            }
            else
            {
                Console.WriteLine("Inválida: mínimo 8 caracteres");
            }
            //Ejercicio#02
            Console.WriteLine("Ejercicio#02");
                Console.WriteLine("Ingrese una palabra");
                Console.WriteLine();
                string palabra = Console.ReadLine();
                for (int b = palabra.Length - 1; b >=0; b--)
                {
                    Console.Write(palabra[b]);   
                }
                Console.WriteLine();
                //Ejercicio#03
                Console.WriteLine("Ejercicio#03");
            Console.WriteLine("¿Cuántos números desea ingresar?");
            int n = int.Parse(Console.ReadLine());

            int[] numeros = new int[n];

            int suma = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Número " + (i + 1) + ": ");
                numeros[i] = int.Parse(Console.ReadLine());
                suma += numeros[i];
            }

            int mayor = numeros[0];
            int menor = numeros[0];

            for (int i = 0; i < n; i++)
            {
                if (numeros[i] > mayor) mayor = numeros[i];
                if (numeros[i] < menor) menor = numeros[i];
            }

            double promedio = (double)suma / n;

            Console.WriteLine("Suma = " + suma);
            Console.WriteLine("Promedio = " + promedio);
            Console.WriteLine("Mayor = " + mayor);
            Console.WriteLine("Menor = " + menor);
            //Ejercicio#04
            Console.WriteLine("Ejercicio#04");
            int[] numeros = new int[8];

            for (int i = 0; i < 8; i++)
            {
                Console.Write("Ingrese número " + (i + 1) + ": ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Número a buscar:");
            int buscar = int.Parse(Console.ReadLine());

            bool encontrado = false;
            int posicion = -1;

            for (int i = 0; i < 8; i++)
            {
                if (numeros[i] == buscar)
                {
                    encontrado = true;
                    posicion = i;
                    break;
                }
            }

            if (encontrado)
            {
                Console.WriteLine("El número sí existe en la posición " + posicion);
            }
            else
            {
                Console.WriteLine("El número no existe en el arreglo");
            }
            //Ejercicio#05
            Console.WriteLine("Ejercicio#05");
            string[] nombres = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese nombre " + (i + 1) + ": ");
                nombres[i] = Console.ReadLine();
            }

            int mas5 = 0;
            string masLargo = nombres[0];

            for (int i = 0; i < 5; i++)
            {
                if (nombres[i].Length > 5)
                    mas5++;

                if (nombres[i].Length > masLargo.Length)
                    masLargo = nombres[i];
            }

            Console.Write("Nombres ingresados: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(nombres[i] + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("Más de 5 letras: " + mas5);
            Console.WriteLine("Nombre más largo: " + masLargo);

        }
        }
    }


