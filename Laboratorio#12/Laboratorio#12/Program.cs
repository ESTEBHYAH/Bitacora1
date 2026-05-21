using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio#01
            Console.WriteLine("Ejercicio01");
            int[,] matriz = new int[4, 4];
            LlenarMatriz(matriz);
            Console.WriteLine("Ingrese la fila");
            int fila = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la columna");
            int columa = int.Parse(Console.ReadLine());
            int sumaf = sumafila(matriz, fila);
            int sumac = sumacolumna(matriz, columa);
            Console.WriteLine("Su suma en la fila es de " + sumaf);
            Console.WriteLine("Su suma en la columna es de " + sumac);
        }
        static void LlenarMatriz(int[,] m)
        {
            Console.WriteLine("Ingrese valores para matriz 4x4:");
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    m[i, j] = int.Parse(Console.ReadLine());
                }
        }
        static int sumafila(int[,] m, int fila)
        {
            int suma = 0;
            for (int j = 0; j < 4; j++)
            {
                suma += m[fila, j];
                return suma;
            }
        }
        static int sumacolumna(int[,] m, int columa)
        {
            int suma = 0;
            for (int i = 0; i < 4; i++)
            {
                suma += m[i, columa];
                return suma;
            }
        }

    }

}

