using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string modelo = "Americagly";
            int capacidad = 20;
            float combustible = 24.8f;
            bool motor = false; 

            Console.WriteLine();
            Console.WriteLine("Este es el modelo de la nave: " + modelo);
            

            Console.WriteLine();
            Console.WriteLine("La capacidad de la nave es: " + capacidad);

            Console.WriteLine();
            Console.WriteLine("Este es el combustisble de la nave: " + combustible);

            Console.WriteLine();
            Console.WriteLine("Su motor esta prendido? " + motor );

            // Ejercicio #4

            short SensoresActivos = 128;
            int RegistroProcesador = SensoresActivos;
            double PrecisionTotal = RegistroProcesador;

            Console.WriteLine();
            Console.WriteLine("Esto es el dato: " + RegistroProcesador);

            // Ejercicio #3

            Console.WriteLine();
            double energiaGenerada = 987.65f;
            int energiaIlimitada = (int)energiaGenerada;
            Console.WriteLine("La energia generada es: " + energiaGenerada);
            Console.WriteLine("La energia ilimitada es: " + energiaIlimitada);

            // Ejercicio # 4

            Console.WriteLine();
            string planetaMasCercano = Console.ReadLine();
            int entradaRadar = int.Parse(planetaMasCercano);
            int distanciaFinal = entradaRadar + 100;
            Console.WriteLine("La distancia final es: " + distanciaFinal);

            // Ejercicio 5

            Console.WriteLine();
            string oxigeno = "True";
            bool oxigenoBool = Convert.ToBoolean(oxigeno);
            string temperatura = "22.8";
            double temCabi = Convert.ToDouble(temperatura);
            Console.WriteLine("El oxigeno en la actualidad es: " + oxigenoBool);
            Console.WriteLine("La temperatura es: " + temCabi);

            // Ejercicio 6
            Console.WriteLine();
            double velocidadLuz = 299792.458;
            string VelocidadString = velocidadLuz.ToString("N3");
            Console.WriteLine("La velocidad es: " + VelocidadString);

            // Ejercicio 7
           
           

           














        }
    }
}
