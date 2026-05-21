using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre, curso;

            Console.Write("Escriba su nombre");
            nombre = Console.ReadLine();

            Console.Write("Escriba su curso");
            curso = Console.ReadLine();

            Console.WriteLine("Bienvenidos " + nombre + " Del curso " + curso + " Feliz dia");

        }
    }
}
