using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio__5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Esteban");
            Console.WriteLine();
            Console.WriteLine("Carnet: 1298126");

            // Ejercicio #1
            Console.WriteLine();
            int ID, PIN, token, modo;
            
            Console.WriteLine("Ingrese ID");
            ID = int.Parse(Console.ReadLine());
            if (ID == 2026) 
            {
                Console.WriteLine("Su ID es correcto");


            }
            else
            {
                Console.WriteLine("Su ID es incorrecto");
            }
            Console.WriteLine("Ingrese su PIN");
            PIN = int.Parse(Console.ReadLine());
            if (PIN == 1234)
            {
                Console.WriteLine();
                Console.WriteLine("Su PIN es correcto");


            }
            else
            {
                Console.WriteLine("Su PIN es incorrecto");

            }
            Console.WriteLine("Ingrese su token");
            token = int.Parse(Console.ReadLine());
            if (token == 777)
            {
                Console.WriteLine();
                Console.WriteLine("Su token es correcto");
            }
            else
            {
                Console.WriteLine("Su token es incorrecto");
            }
            Console.WriteLine();
            Console.WriteLine("Ingrese su su modoSeguro");
            modo = int.Parse(Console.ReadLine());
            if (modo == 1)
            {
                Console.WriteLine("Su comprobacion esta encendida");
            }
            else
            {
                Console.WriteLine("Su comprobacion esta apagada");
            }
            Console.WriteLine();
            if (PIN == 2026 && PIN == 1234 && token == 777)
            {
                Console.WriteLine("Acceso total permitido");
            }
            else
            {
                Console.WriteLine("No permitido el accesso total");
            }
            Console.WriteLine();
            if (modo == 1 && token == 777)
            {
                Console.WriteLine("Regla aprobada");
            }
            else
            {
                Console.WriteLine("Su regla no es aprobada");
            }
            //Ejercicios #2
            int PIN_2;
            Console.WriteLine("Ingrese otro PIN");
            PIN_2 = int.Parse(Console.ReadLine());
            if (PIN_2 >=1000 && PIN_2 <=9999)
            {
                Console.WriteLine("Su PIN es de 4 digitos");
            }
            else
            {
                Console.WriteLine("Su PIN no es de 4 digitos");
            }
            Console.WriteLine();
            if (PIN_2 % 2 == 0)
            {
                Console.WriteLine("Su PIN es par");
            }
            else
            {
                Console.WriteLine("Su PIN es impar");
            }
            Console.WriteLine();
            if (PIN_2 % 5 == 0)
            {
                Console.WriteLine("Su PIN es multiplo de 5");
            }
            else
            {
                Console.WriteLine("Su PIN no es multiplo de 5");

            }
            Console.WriteLine();
            if (PIN_2 >= 1000 && PIN_2 <= 9999 && PIN_2 % 2 == 0 && PIN_2 % 5 != 0)
            {
                Console.WriteLine("Su PIN es aprobado por politica");
            }
            else
            {
                Console.WriteLine("Su PIN no es aprobado por politica");
            }
            // Ejercicio # 3
            int codigoActivacion, Edad, puntuaje;
            int Terminos;
            int verificacion;
            Console.WriteLine();
            Console.WriteLine("Ponga su codigo de activacion ");
            codigoActivacion = int.Parse(Console.ReadLine());
            if (codigoActivacion == 2026)
            {
                Console.WriteLine("Su codigo es correcto");
            }
            else
            {
                Console.WriteLine("Su codigo es incorrector");
            }
            Console.WriteLine();
            Console.WriteLine("Ingrese su edad");
            Edad = int.Parse(Console.ReadLine());
            if (Edad >= 18)
            {
                Console.WriteLine("Su edad es mayor");
            }
            else
            {
                Console.WriteLine("Su edad es menor");
            }
            Console.WriteLine();
            Console.WriteLine("Coloque si su termino de condiciones. 1 = yes, 0= no");
            Terminos = int.Parse(Console.ReadLine());
            if (Terminos == 1) 
            {
                Console.WriteLine("Terminos aceptados");
            }
            else
            {
                Console.WriteLine("Terminos no aceptados");
            }
            Console.WriteLine();
            Console.WriteLine("Coloque su verificacion: 1 true, 0 false");
            verificacion = int.Parse(Console.ReadLine());
            if (verificacion == 1)
            {
                Console.WriteLine("Su verificacion es correcta");
            }
            else
            {
                Console.WriteLine("Su verificacion es incorrecta");
            }
            Console.WriteLine();
            Console.WriteLine("Coloque su puntuaje: ");
            puntuaje = int.Parse(Console.ReadLine());
            if (puntuaje >= 70)
            {
                Console.WriteLine("Su puntaje es correcto");
            }
            else
            {
                Console.WriteLine("Es incorrecto su puntaje");
            }
            Console.WriteLine();
            if (codigoActivacion == 2026 && Edad >= 18 && Terminos == 1 && verificacion == 1 && puntuaje >= 70)
            {
                Console.WriteLine("Su cuenta a sido exitosamente abierta");

            }
            else
            {
                Console.WriteLine("Su cuenta no a sido abierta");
            }
            // Ejercicio #4
            int notas, minutos, pagos, identificacion, calculadora;
            Console.WriteLine();
            Console.WriteLine("Ponga sus notas totales");
            notas = int.Parse(Console.ReadLine());
            if (notas >= 61)
            {
                Console.WriteLine("Sus notas han sido aprobadas");
            }
            else
            {
                Console.WriteLine("Sus notas no han sido aprobadas");
            }
            Console.WriteLine();
            Console.WriteLine("Coloque su hora de llegada");
            minutos = int.Parse(Console.ReadLine());
            if (minutos >= 10)
            {
                Console.WriteLine("Hora valida");
            }
            else
            {
                Console.WriteLine("Hora invalida");
            }
            Console.WriteLine();
            Console.WriteLine("Coloque si su pago fue realizado. Si = 1");
            pagos = int.Parse(Console.ReadLine());
            if (pagos == 1)
            {
                Console.WriteLine("Con solvencia");
            }
            else
            {
                Console.WriteLine("Sin solvencia");
            }
            Console.WriteLine();
            Console.WriteLine("Coloque su identificacion");
            identificacion = int.Parse(Console.ReadLine());
            if (identificacion == 1)
            {
                Console.WriteLine("Identificacion valida");
            }
            else
            {
                Console.WriteLine("Sin identificacion");
            }
            Console.WriteLine();
            Console.WriteLine("Trae calculadora: si = 1");
            calculadora = int.Parse(Console.ReadLine());
            if (calculadora == 1)
            {
                Console.WriteLine("Calculadora permita");
            }
            else
            {
                Console.WriteLine("Calculadora no permitida");
            }
            Console.WriteLine();
            if (notas >= 61 && minutos <= 10 && pagos == 1 && identificacion == 1 && calculadora == 1)
            {
                Console.WriteLine("Acceso a la sala de examen");
            }
            else
            {
                Console.WriteLine("Acceso denegado");
            }
            Console.WriteLine();
            if (minutos > 0 && minutos <= 10)
            {
                Console.WriteLine("Aun puede ingresar a clase");
            }
            else
            {
                Console.WriteLine("Acesso denegado por falta de tiempo");
            }
            
            
           













        }
    }
}
