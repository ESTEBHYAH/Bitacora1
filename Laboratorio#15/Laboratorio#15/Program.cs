using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Falta de comillas en diversos lugares
            string nombre;
            int edad;
            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad:");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Hola " + nombre);
            Console.WriteLine("Tienes " + edad + " años");
            if (edad >= 18)
            {
                Console.WriteLine("Usted es mayor de edad");
                //Falta cerrar las llaves de el if
            }
            else
            {
                Console.WriteLine("Eres menor de edad");
            }
            Console.WriteLine("Ejercicio02");
            double nota1, nota2, nota3, promedio;
            Console.WriteLine("Ingrese la primera nota:");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota:");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercera nota:");
            nota3 = double.Parse(Console.ReadLine());
            //Error encontrado: Logico debido al problema de la estructuracion de el promedio
            promedio = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine("El promedio es: " + promedio);
            if (promedio > 61)
            {
                Console.WriteLine("El estudiante aprobó");
            }
            else
            {
                Console.WriteLine("El estudiante reprobó");
            }
            Console.Write("Ejercicio#03");
            int[] numeros = new int[5];
            int sumaNumeros = 0;

            //Error encontrado: el ciclo llegaba hasta 5 y el arreglo solo tiene posiciones 0 a 4
            for (int i = 0; i < numeros.Length; i++)
            {
                int numero;
                bool valido = false;

                while (!valido)
                {
                    Console.WriteLine("Ingrese un número:");

                    //Error encontrado: si se escribía texto el programa fallaba
                    if (int.TryParse(Console.ReadLine(), out numero))
                    {
                        numeros[i] = numero;
                        valido = true;
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida. Intente de nuevo.");
                    }
                }
            }

            //Error encontrado: también se intentaba sumar una posición que no existe
            for (int i = 0; i < numeros.Length; i++)
            {
                sumaNumeros = sumaNumeros + numeros[i];
            }

            Console.WriteLine("La suma total es: " + sumaNumeros);


            Console.WriteLine("Ejercicio#4");

            double baseRectangulo = 0;
            double alturaRectangulo = 0;
            bool baseValida = false;
            bool alturaValida = false;

            while (!baseValida)
            {
                Console.WriteLine("Ingrese la base del rectángulo:");

                //Error encontrado: si se escribía texto el programa fallaba
                if (double.TryParse(Console.ReadLine(), out baseRectangulo))
                {
                    //Error encontrado: no se validaban números menores o iguales a cero
                    if (baseRectangulo > 0)
                    {
                        baseValida = true;
                    }
                    else
                    {
                        Console.WriteLine("La base debe ser mayor que cero.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida.");
                }
            }

            while (!alturaValida)
            {
                Console.WriteLine("Ingrese la altura del rectángulo:");

                //Error encontrado: si se escribía texto el programa fallaba
                if (double.TryParse(Console.ReadLine(), out alturaRectangulo))
                {
                    //Error encontrado: no se validaban números menores o iguales a cero
                    if (alturaRectangulo > 0)
                    {
                        alturaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("La altura debe ser mayor que cero.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida.");
                }
            }

            //Error encontrado: lógico, el área se estaba sumando y debe multiplicarse
            double area = baseRectangulo * alturaRectangulo;

            Console.WriteLine("El área es: " + area);

            //Error encontrado: lógico, si el área era 100 debía ser grande
            if (area >= 100)
            {
                Console.WriteLine("El área es grande");
            }
            else
            {
                Console.WriteLine("El área es pequeña");
            }


            Console.WriteLine("Ejercicio#5");

            int[] edades = new int[5];
            int sumaEdades = 0;
            int mayores = 0;
            double promedioEdades;

            //Análisis de la solución generada por IA:
            //Error 1: usaba mal las posiciones del arreglo
            //Error 2: no contaba como mayor de edad a una persona de 18 años
            //Error 3: el promedio podía perder decimales
            //Limitación encontrada: no validaba texto ni edades negativas
            //Importancia de la validación humana: se debe revisar porque la IA puede equivocarse

            for (int i = 0; i < edades.Length; i++)
            {
                int edad1;
                bool edadValida = false;

                while (!edadValida)
                {
                    Console.WriteLine("Ingrese la edad de la persona " + (i + 1) + ":");

                    //Error encontrado: si se escribía texto el programa fallaba
                    if (int.TryParse(Console.ReadLine(), out edad1))
                    {
                        //Error encontrado: aceptaba edades negativas
                        if (edad1 >= 0)
                        {
                            edades[i] = edad1;
                            edadValida = true;
                        }
                        else
                        {
                            Console.WriteLine("La edad no puede ser negativa.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida.");
                    }
                }

                sumaEdades = sumaEdades + edades[i];

                //Error encontrado: lógico, 18 años también cuenta como mayor de edad
                if (edades[i] >= 18)
                {
                    mayores++;
                }
            }

            //Error encontrado: lógico, se usa 5.0 para que el promedio tenga decimales
            promedioEdades = sumaEdades / 5.0;

            Console.WriteLine("El promedio de edades es: " + promedioEdades);
            Console.WriteLine("Cantidad de mayores de edad: " + mayores);

            //¿Por qué una solución generada por Inteligencia Artificial debe ser revisada?
            //Porque puede tener errores aunque parezca correcta.
            //Puede equivocarse en condiciones o fórmulas.
            //También puede olvidar validar datos.
            //Por eso se debe probar con varios casos.
            //La IA ayuda, pero una persona debe revisar el código.
        }
    }
}
