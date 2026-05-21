using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_13
{
    internal class Program
    {
        //Ejercicio#01
        class Persona
        {
            public string nombre;
            public int edad;
            public double altura;
            public bool estudiante;
        }
        //Ejercicio#02
        class Vehiculo
        {
            public string marca;
            public string modelo;
            public int anio;
            public string color;
            public string placa;
        }
        //Ejercicio#03
        class Producto
        {
            public string codigo;
            public string nombre;
            public double precio;
            public int stock;
            public bool disponible;
        }
        //Ejercicio#04
        class Mascota
        {
            public string nombre;
            public string especie;
            public int edad;
            public double peso;
            public bool vacunado;
        }
        static void Main(string[] args)
        {
            Persona personaPrincipal = new Persona();
            personaPrincipal.nombre = "Carlos";
            personaPrincipal.edad = 19;
            personaPrincipal.altura = 1.70;
            personaPrincipal.estudiante = true;

            Console.WriteLine("=== Persona ===");
            Console.WriteLine("Nombre: " + personaPrincipal.nombre);
            Console.WriteLine("Edad: " + personaPrincipal.edad);
            Console.WriteLine("Altura: " + personaPrincipal.altura);
            Console.WriteLine("Estudiante: " + personaPrincipal.estudiante);
            Console.WriteLine();

            // ========= Vehiculo =========
            Vehiculo vehiculoPersonal = new Vehiculo();
            vehiculoPersonal.marca = "Honda";
            vehiculoPersonal.modelo = "Civic";
            vehiculoPersonal.anio = 2021;
            vehiculoPersonal.color = "Negro";
            vehiculoPersonal.placa = "P456XYZ";

            Console.WriteLine("=== Vehiculo ===");
            Console.WriteLine("Marca: " + vehiculoPersonal.marca);
            Console.WriteLine("Modelo: " + vehiculoPersonal.modelo);
            Console.WriteLine("Año: " + vehiculoPersonal.anio);
            Console.WriteLine("Color: " + vehiculoPersonal.color);
            Console.WriteLine("Placa: " + vehiculoPersonal.placa);
            Console.WriteLine();

            // ========= Productos =========
            Producto productoPrincipal = new Producto();
            productoPrincipal.codigo = "A01";
            productoPrincipal.nombre = "Teclado";
            productoPrincipal.precio = 250.50;
            productoPrincipal.stock = 15;
            productoPrincipal.disponible = true;

            Producto productoSecundario = new Producto();
            productoSecundario.codigo = "A02";
            productoSecundario.nombre = "Monitor";
            productoSecundario.precio = 1200.00;
            productoSecundario.stock = 8;
            productoSecundario.disponible = true;

            Console.WriteLine("=== Producto 1 ===");
            Console.WriteLine("Codigo: " + productoPrincipal.codigo);
            Console.WriteLine("Nombre: " + productoPrincipal.nombre);
            Console.WriteLine("Precio: " + productoPrincipal.precio);
            Console.WriteLine("Stock: " + productoPrincipal.stock);
            Console.WriteLine("Disponible: " + productoPrincipal.disponible);
            Console.WriteLine();

            Console.WriteLine("=== Producto 2 ===");
            Console.WriteLine("Codigo: " + productoSecundario.codigo);
            Console.WriteLine("Nombre: " + productoSecundario.nombre);
            Console.WriteLine("Precio: " + productoSecundario.precio);
            Console.WriteLine("Stock: " + productoSecundario.stock);
            Console.WriteLine("Disponible: " + productoSecundario.disponible);
            Console.WriteLine();

            // ========= Mascota =========
            Mascota mascotaCasa = new Mascota();
            mascotaCasa.nombre = "Luna";
            mascotaCasa.especie = "Gato";
            mascotaCasa.edad = 3;
            mascotaCasa.peso = 4.2;
            mascotaCasa.vacunado = true;

            Console.WriteLine("=== Mascota ===");
            Console.WriteLine("Nombre: " + mascotaCasa.nombre);
            Console.WriteLine("Especie: " + mascotaCasa.especie);
            Console.WriteLine("Edad: " + mascotaCasa.edad);
            Console.WriteLine("Peso: " + mascotaCasa.peso);
            Console.WriteLine("Vacunado: " + mascotaCasa.vacunado);
        }
    }
}
        
    

        
 

