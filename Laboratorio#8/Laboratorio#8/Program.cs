using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
           int nota, cantidadApro = 0, CantidadRepro = 0, suma = 0;
            double promedio = 0;
            Console.WriteLine("Ejercicio#1");
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese las notas");
                nota = int.Parse(Console.ReadLine());
                if (nota >= 61 )
                {
                    cantidadApro++;
                }
                else
                {
                    CantidadRepro++;
                }
                suma = suma + nota;
            }
            promedio = suma / 10;
            Console.WriteLine();
            Console.WriteLine("Su promedio fue de: " + promedio);
            Console.WriteLine();
            Console.WriteLine("Los aprobados fueron: " + cantidadApro);
            Console.WriteLine();
            Console.WriteLine("Los reprobados fueron: " + CantidadRepro);
            Console.WriteLine();

            //Ejercicio#2
            Console.WriteLine("Ejercicio#2");
            int num, numerosPares = 0, numerosImpares = 0, cont = 0;
            num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Ingrese un numero: ");
            Console.WriteLine();
            while (cont <= num)
            {
                cont = cont++;
               if (cont % 2 == 0)
                {
                    numerosPares++;
                }
               else
                {
                    numerosImpares++;
                }
            }
            Console.WriteLine("La suma es: " + cont);
            Console.WriteLine();
            Console.WriteLine("Los numeros pares son: " + numerosPares);
            Console.WriteLine();
            Console.WriteLine("Los numeros impares son: " + numerosImpares);
            Console.WriteLine();

            //Ejercicio 3
            Console.WriteLine("Ejercicio#3");
            Console.WriteLine();
            int menu, monto, montoTotal = 0, clientes = 0;
            Console.WriteLine("Ingrese a que menu quiere entar: ");
            Console.WriteLine();
            Console.WriteLine("1) Registrar compra 2) Mostrar total de ventas 3) Mostrar cantidad de clientes atendidos 4) Salir");
            menu = int.Parse(Console.ReadLine());
            do
            {
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Cual es el monto de su compra");
                        monto = int.Parse(Console.ReadLine());
                        montoTotal = montoTotal + monto;
                        clientes = clientes++;
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Sus ventas totales fueron: " + montoTotal);
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Los clientes que recibio fueron: " + clientes);
                        break;
                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("Salida");
                        break;
                    default:
                        Console.WriteLine("Numero no correspondiente");
                        break;
                }
            } while (menu != 4);
            // Ejericicio#5
            Console.WriteLine();
            Console.WriteLine("Ejercicio#4");
            int num2, posi = 0, neg = 0, sumatotal = 0, cont1 = 0;
            do
            {
                cont1 = cont++;
                Console.WriteLine("Ingrese un numero");
                num2 = int.Parse(Console.ReadLine());
                sumatotal = sumatotal + num2;
                if (num2 > 0)
                {
                    posi = posi++;
                }
                else
                {
                    neg = neg++;
                }
            } while (num2 != 0);
            Console.WriteLine();
            Console.WriteLine("La cantidad de numeros fueron: " + cont1);
            Console.WriteLine();
            Console.WriteLine("Su suma fue de :" +sumatotal);
            Console.WriteLine();
            Console.WriteLine("La cantidad de positivos fueron: " + posi);
            Console.WriteLine();
            Console.WriteLine("La cantidad de negativos fueron: " + neg);

            //Ejercicio 5
            Console.WriteLine();
            Console.WriteLine("Ejercicio#5");
            int N;
            Console.WriteLine("Ingrese un numero");
            N = int.Parse(Console.ReadLine());
            for (int i2 = 1; i2 <= N; i2++)
            {
                for (int j = 1; j <= i2; j++)
                {
                    Console.WriteLine(j + i2);
                }
            }
        }
    }
}
