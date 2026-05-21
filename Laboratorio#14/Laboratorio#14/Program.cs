using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_14
{
    //Ejercicio#01
    class libro
    {
        // Atributos
        public string titulo;
        public string autor;
        public int anioPublicacion;
        public bool disponible;

        // Constructor
        public libro(string titulo, string autor, int aniopublicacion, bool disponible)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anioPublicacion = aniopublicacion;
            this.disponible = disponible;
        }

        // Mostrar información
        public void mostrarInformacion()
        {
            Console.WriteLine("Título: " + titulo);
            Console.WriteLine("Autor: " + autor);
            Console.WriteLine("Año de publicación: " + anioPublicacion);
            Console.WriteLine("Disponible: " + disponible);
            Console.WriteLine();
        }

        // Prestar libro
        public void prestarLibro()
        {
            if (disponible == true)
            {
                disponible = false;
                Console.WriteLine("El libro fue prestado.");
            }
            else
            {
                Console.WriteLine("El libro no está disponible.");
            }
        }

        // Devolver libro
        public void devolverLibro()
        {
            disponible = true;
            Console.WriteLine("El libro ha sido devuelto");
        } 
      
    }
    //Ejercicio#02
    class mascota
    {
        public string nombre;
        public string especie;
        public int edad;
        public bool vacunado;
        //Constructor 
        public mascota(string nombre, string especie, int edad, bool vacunado)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.edad = edad;
            this.vacunado = vacunado;
        }
        //Mostarinformacion
        public void mostarInformacion1()
        {
            Console.WriteLine("Su nombre es de: " + nombre);
            Console.WriteLine("Su especie es: " + especie);
            Console.WriteLine("Su edad es: " + edad);
            Console.WriteLine("Esta vacunado? " + vacunado);
        }
        public void vacunar()
        {
            if (vacunado == false)
            {
                Console.WriteLine("Su mascota no esta vacunada. Vacunar");
                vacunado = true;
            }
            else
            {
                Console.WriteLine("Su mascota ya esta vacunada");
            }
        }
        public void cumplirAnios()
        {
            edad++;
        }
        internal class Program
        {
        }
        // Ejercicio #03
        class Estudiante
        {
            // Atributos
            public string nombre;
            public int edad;
            public string grado;
            public double[] notas;

            // Constructor
            public Estudiante(string nombre, int edad, string grado, double[] notas)
            {
                this.nombre = nombre;
                this.edad = edad;
                this.grado = grado;
                this.notas = notas;
            }

            // Calcular promedio
            public double calcularPromedio()
            {
                double suma = 0;

                for (int i = 0; i < notas.Length; i++)
                {
                    suma += notas[i];
                }

                return suma / notas.Length;
            }

            // Mostrar información
            public void mostrarInformacion()
            {
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Edad: " + edad);
                Console.WriteLine("Grado: " + grado);

                Console.Write("Notas: ");

                for (int i = 0; i < notas.Length; i++)
                {
                    Console.Write(notas[i] + " ");
                }

                Console.WriteLine();
                Console.WriteLine("Promedio: " + calcularPromedio());
            }

            // Aprobar
            public void aprobar()
            {
                if (calcularPromedio() >= 61)
                {
                    Console.WriteLine("El estudiante aprobó");
                }
                else
                {
                    Console.WriteLine("El estudiante reprobó");
                }
            }

            // Agregar nueva nota
            public void agregarNota(double nuevaNota)
            {
                double[] nuevasNotas = new double[notas.Length + 1];

                for (int i = 0; i < notas.Length; i++)
                {
                    nuevasNotas[i] = notas[i];
                }

                nuevasNotas[notas.Length] = nuevaNota;

                notas = nuevasNotas;
            }
        }


        static void Main(string[] args)
            {
                libro libro1 = new libro("Harry Potter", "J.K Rowling", 1997, true);
                libro1.mostrarInformacion();
                libro1.prestarLibro();
                libro1.mostrarInformacion();
                libro1.devolverLibro();
                libro1.mostrarInformacion();
                libro libro2 = new libro("Naruto", "Mashashi Kishimoto", 1999, true);
                libro2.mostrarInformacion();
                libro2.prestarLibro();
                libro2.mostrarInformacion();
                libro2.devolverLibro();
                //Ejercicio#02
                mascota mascota1 = new mascota("Peach", "Perro", 10, true);
                mascota1.mostarInformacion1();
                mascota1.vacunar();
                mascota1.cumplirAnios();
            Console.WriteLine("Despues de cumplir anios");
            mascota1.mostarInformacion1();
                mascota mascota2 = new mascota("Limon", "Perro", 6, false);
                mascota2.mostarInformacion1();
                mascota2.vacunar();
                mascota2.cumplirAnios();
            Console.WriteLine("Despues de cumplir anios");
            mascota2.mostarInformacion1();
            //Ejercicio#03
            double[] notas1 = { 70, 80, 90 };
            double[] notas2 = { 50, 55, 60 };

            Estudiante estudiante1 = new Estudiante("Carlos", 16, "4to Bach", notas1);
            Estudiante estudiante2 = new Estudiante("Ana", 17, "5to Bach", notas2);

            estudiante1.mostrarInformacion();
            estudiante1.aprobar();

            Console.WriteLine();

            estudiante2.mostrarInformacion();
            estudiante2.aprobar();

            Console.WriteLine();

            estudiante2.agregarNota(100);

            Console.WriteLine("Nueva información del estudiante 2:");

            estudiante2.mostrarInformacion();
            estudiante2.aprobar();

        }
        }
    }
