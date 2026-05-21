using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Laboratorio 9, Procedimientos");
            Console.WriteLine();

            //Ejercicio#Prueba
            Console.WriteLine("Ejercico de prueba");
            Console.WriteLine("Ingrese un numero 1 y 2");
            int num1, num2;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Ejercicio#01
            Console.WriteLine("Ejercicio#01");
            Console.WriteLine();
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();
            saludo(nombre);
            Console.WriteLine();
            curso();
            Console.WriteLine();

            //Ejercicio#02
            Console.WriteLine("Ejercicio#02");
            int opcion, areas = 0, basetc, altura;
            Console.WriteLine();
            Console.WriteLine("Cual opcion desea tomar. 1. Cuadrado. 2. Triangulo. 3. Rectangulo");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese lado del cuadrado");
                    basetc = int.Parse(Console.ReadLine());
                    cuadrado(basetc);
                    break;
                case 2:
                    Console.WriteLine("Ingrese base y altura del triangulo");
                    basetc = int.Parse(Console.ReadLine());
                    altura = int.Parse(Console.ReadLine());
                    triangulo(basetc, altura);
                    break;
                case 3:
                    Console.WriteLine("Ingrese base y altura de el rectangulo");
                    basetc = int.Parse(Console.ReadLine());
                    altura = int.Parse(Console.ReadLine());
                    rectangulo(basetc, altura);
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;

            }
            Console.WriteLine();
            // Ejercicio#03
            Console.WriteLine("Ejercicio#03");
            int opcion1;
            Console.WriteLine("MENU");
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Triángulo");
            Console.WriteLine("3. Línea");
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opción: ");
            opcion1 = int.Parse(Console.ReadLine());
            do
            {
                switch (opcion1)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Ingrese el numero que quiere imprimir");
                        int m;
                        m = int.Parse(Console.ReadLine());
                        cua(m);
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Ingrese el numero que quiere imprimir");
                        int a;
                        a = int.Parse(Console.ReadLine());
                        trian(a);
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Ingrese el numero que quiere imprimir");
                        int z;
                        z = int.Parse(Console.ReadLine());
                        linea(z);
                        break;
                    case 4:
                        Console.WriteLine("salir");
                        break;

                }
            } while (opcion != 4);
            // Ejercicio #04
            Console.WriteLine();
            double nota;
            double suma = 0;
            int aprobados = 0, reprobados = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Ingrese la nota #" + i + ": ");
                nota = double.Parse(Console.ReadLine());

                EvaluarNota(nota, ref aprobados, ref reprobados);

                suma += nota;
            }
             double promedio = suma / 5;
             MostrarResumen(promedio, aprobados, reprobados);
            // Ejercicio #05
            Console.WriteLine("Ejercicio#05");
            int n1, n2;

            Console.Write("Ingrese el primer número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Antes: " + n1 + ", " + n2);

            Intercambiar(ref n1, ref n2);

            Console.WriteLine("Después: " + n1 + ", " + n2);





        }
        static void suma(int a, int b)
        {
            a = a + 5;
            int suma = a + b;
            Console.WriteLine("La suma es" + suma);
        }
        static void saludo(string nom)
        {
            Console.WriteLine("Hola que tal? Seas bienvenido " + nom);
        }
        static void curso()
        {
            Console.WriteLine("Su curso es: Laboratorio de computacion y su carnet 1298126");
        }
        static void cuadrado(int lado)
        {
            lado = lado * lado;
        }
        static void triangulo(int basee, int altura)
        {
            int area = (basee * altura) / 2;
        }
        static void rectangulo(int basee, int altura)
        {
            int area = (basee * altura);
        }
        static void cua(int n)
        {
            for (int i = 0; i< n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("*");
                }
            }
        }
        static void trian(int n)
        {
            for (int i = 1; i<=n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine("*");
                }
            }
        }
        static void linea(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("*");
            }
        }
        static void EvaluarNota(double nota, ref int aprobados, ref int reprobados)
        {
            if (nota >= 61)
            {
                Console.WriteLine("Aprobado");
                aprobados++;
            }
            else
            {
                Console.WriteLine("Reprobado");
                reprobados++;
            }
        }

        // Procedimiento para mostrar el resumen
        static void MostrarResumen(double promedio, int aprobados, int reprobados)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Aprobados: " + aprobados);
            Console.WriteLine("Reprobados: " + reprobados);
        }
        static void Intercambiar(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }


    }
}
