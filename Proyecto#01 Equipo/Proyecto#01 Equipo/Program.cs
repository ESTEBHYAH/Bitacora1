using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_01_Equipo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion, codigoTurno;
            Console.Write("Ingrese su nombre(operador) por favor: ");
            string nombreOperador = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Su nombre es :" + nombreOperador + " Ingrese su codigo de turno: (4 caracteres)");
            Console.WriteLine();
            codigoTurno = int.Parse(Console.ReadLine());
            int ticketsCreados = 0, ticketsCerrados = 0, tiempoSimulado = 0, tiempoTotal = 0, minutoEntrada, tipoVehiculo, capacidadParqueo = 0;
            double dineroRecaudado = 0.00;
            bool ticketActivo = false;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Bienvenido a  SmartPark");
                Console.WriteLine("Elija que desea elegir.");
                Console.WriteLine("1.CREAR TICKET DE ENTRADA");
                Console.WriteLine("2.REGISTRAR SALIDA Y CALCULAR COBRO");
                Console.WriteLine("3. VER ESTADO DEL PARQUEO");
                Console.WriteLine("4. SIMULAR PASO DEL TIEMPO");
                Console.WriteLine("5. Salir");
                Console.WriteLine("Cual desea elegir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                       if (capacidadParqueo < 10)
                        {
                            if (!ticketActivo)
                            {
                                int placa;
                                Console.WriteLine("Por favor ingrese su placa: (6 a 8 caracteres, sin espacios).");
                                placa = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.WriteLine("Ingrese de cual es su tipo de vehiculo:  (1 = Moto, 2 = Auto, 3 = Pickup/SUV).");
                                tipoVehiculo = int.Parse(Console.ReadLine());
                                switch (tipoVehiculo)
                                {
                                    case 1:
                                        Console.WriteLine("Su vehiculo es una moto");
                                        tipoVehiculo = 1;
                                        break;
                                    case 2:
                                        Console.WriteLine("Su vehiculo es un auto");
                                        tipoVehiculo = 2;
                                        break;
                                    case 3:
                                        Console.WriteLine("Su vehiculo es un pickup");
                                        break;
                                    default:
                                        Console.WriteLine("Vehiculo no indicado");
                                        break;
                                }
                                Console.WriteLine();
                                Console.WriteLine("Ingrese su nombre por favor");
                                string nombreCliente = Console.ReadLine();
                                Console.WriteLine("Bienvenido " + nombreCliente + " Es un gusto");
                                Console.WriteLine();
                                Console.WriteLine("Cumplio todo requerido");
                                ticketsCreados++;
                                capacidadParqueo++;
                            }
                        }
                       else
                        {
                            Console.WriteLine("Espacio lleno por favor salir del menu: (precione 5");
                            opcion = int.Parse(Console.ReadLine());
                        }
                            break;
                    case 2:
                        if (ticketActivo)
                        {
                            Console.WriteLine();
                            Console.WriteLine("No a creado ningun ticket");
                        }
                        else
                        {
                            int tiempoActual, minutosEstacionados = 0;
                            
                        }

                            break;

                    case 3:

                        break;

                    case 4:

                        break;

                    case 5:

                        break;
                    default: 

                        break;
                }
            } while (opcion != 5);
           
        }
    }
}
