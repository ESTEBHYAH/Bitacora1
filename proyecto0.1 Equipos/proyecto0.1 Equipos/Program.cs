using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto0._1_Equipos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion, capacidadParqueo;
            Console.Write("Ingrese su nombre(operador) por favor: ");
            Console.WriteLine();
            string nombreOperador = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Su nombre es: " + nombreOperador + " Ingrese su codigo de turno: (4 caracteres)");
            Console.WriteLine();
            string codigoTurno = Console.ReadLine();
            while (codigoTurno.Length != 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Indico mas de 4 digitos incorrecto");
                Console.ResetColor();
                codigoTurno = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Su codigo fue permito. Bienvenido");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Ingrese la capacidad total de los parqueos");
            capacidadParqueo = int.Parse(Console.ReadLine());
            while (capacidadParqueo < 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Mal ingresado la capacidad de parqueos. Deben ser mayor a 10");
                Console.ResetColor();
                capacidadParqueo = int.Parse(Console.ReadLine());
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Parqueos correctos su capacidad es de " + capacidadParqueo);
            Console.ResetColor();
            Console.WriteLine();
            int ticketsCreados = 0, ticketsCerrados = 0, tiempoSimulado = 0, tiempoTotal = 0, minutoEntrada = 0, tiempoActual, minutosEstacionados = 0, tipoVehiculo = 0, parqueoUsado = capacidadParqueo, cobroFraccion = 0, sumadorTiempo = 0, ticketActivo = 0, numeroParqueo = 0;
            double descuentoVIP = 0.00, montoFinal = 0.00, sumaFinal = 0.00, tarifa = 0;
            do
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("=======MENU========");
                Console.WriteLine("Bienvenido a  SmartPark");
                Console.WriteLine("Elija que desea elegir.");
                Console.WriteLine("1.CREAR TICKET DE ENTRADA");
                Console.WriteLine("2.REGISTRAR SALIDA Y CALCULAR COBRO");
                Console.WriteLine("3. VER ESTADO DEL PARQUEO");
                Console.WriteLine("4. SIMULAR PASO DEL TIEMPO");
                Console.WriteLine("5. Salir");
                Console.ResetColor();
                Console.WriteLine("Cual desea elegir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        if (numeroParqueo < capacidadParqueo)
                        {
                            if (ticketActivo == 0)
                            {
                                Console.WriteLine("Por favor ingrese su placa: (6 a 8 caracteres, sin espacios).");
                                string placa = Console.ReadLine();
                                while (placa.Length < 6 || placa.Length > 8)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Placa mal colocada, vuelva a escribir por favor");
                                    Console.ResetColor();
                                    placa = Console.ReadLine();
                                }
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Placa bien colocada");
                                Console.ResetColor();
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
                                Console.WriteLine("¿Cual fue el minuto en el que entro?");
                                minutoEntrada = int.Parse(Console.ReadLine());
                                Console.WriteLine("Cumplio todo requerido");
                                ticketActivo = 1;
                                ticketsCreados++;
                                numeroParqueo++;
                                parqueoUsado--;
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Error. Ticket activo pase al menu. 2.");
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Espacio lleno por favor salir del menu: (precione 5)");
                            Console.ResetColor();
                            opcion = int.Parse(Console.ReadLine());
                        }
                        break;
                    case 2:
                        if (ticketActivo == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine();
                            Console.WriteLine("No a creado ningun ticket");
                            Console.ResetColor();
                        }
                        else
                        {
                            descuentoVIP = 0.00;
                            int horas, VIP;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Ticket permitido");
                            Console.ResetColor();
                            Console.WriteLine();
                            Console.WriteLine("Cuanto tiempo estuvo en el estaciomiento, en minutos");
                            Console.WriteLine();
                            tiempoActual = int.Parse(Console.ReadLine());
                            while (tiempoActual < minutoEntrada)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Esta mal puesto el numero actual, no puede ser menor al minuto de entrada");
                                Console.ResetColor();
                                tiempoActual = int.Parse(Console.ReadLine());
                            }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Bien colocado el tiempo actual");
                            Console.ResetColor();
                            minutosEstacionados = tiempoActual - minutoEntrada;
                            if (minutosEstacionados < 120)
                            {
                                horas = 1;
                            }
                            else if (minutosEstacionados < 180)
                            {
                                horas = 2;
                            }
                            else if (minutosEstacionados < 240)
                            {
                                horas = 3;
                            }
                            else if (minutosEstacionados < 300)
                            {
                                horas = 4;
                            }
                            else if (minutosEstacionados < 360)
                            {
                                horas = 5;
                            }
                            else 
                            {
                                horas = 6;
                            }
                            if (tipoVehiculo == 1)
                            {
                                tarifa = 5 * horas;
                            }
                            if (tipoVehiculo == 2)
                            {
                                tarifa = 10 * horas;
                            }
                            if (tipoVehiculo == 3)
                            {
                                tarifa = 15 * horas;
                            }
                            Console.WriteLine();
                            Console.WriteLine("Usted es cliente VIP? 1. Si es. 0. Si no es");
                            VIP = int.Parse(Console.ReadLine());
                            if (VIP == 0)
                            {
                                Console.WriteLine("Tarifa se queda igual");
                                Console.WriteLine("Su tarifa es de: " + tarifa);

                            }
                            if (VIP == 1)
                            {
                                descuentoVIP = tarifa * 0.10;
                                tarifa -= descuentoVIP;
                                montoFinal = tarifa + cobroFraccion;
                                Console.WriteLine("Su pago es de: " + montoFinal);
                            }
                            montoFinal = tarifa + cobroFraccion;
                            Console.WriteLine("Su pago es de: " + montoFinal);
                            if (minutosEstacionados <= 15)
                            {
                                cobroFraccion = 0;
                            }
                            else 
                            {
                                cobroFraccion = 15;
                            }
                            Console.WriteLine();
                            montoFinal = (tarifa - descuentoVIP) + cobroFraccion;
                            sumaFinal = sumaFinal + montoFinal;
                            Console.WriteLine("El total de los pagos son de: " + sumaFinal);
                            ticketsCerrados++;
                            parqueoUsado--;
                            numeroParqueo--;
                            tiempoTotal = tiempoTotal + minutosEstacionados;
                            ticketActivo = 0;
                        }

                        break;

                    case 3:
                        Console.WriteLine("La capacidad total del parqueo es: " + capacidadParqueo);
                        Console.WriteLine();
                        Console.WriteLine("Los espacios disponibles son: " + parqueoUsado);
                        Console.WriteLine();
                        Console.WriteLine("Los espacios ocupados son: " + numeroParqueo);
                        Console.WriteLine();
                        Console.WriteLine("El tiempo simulado fue de: " + tiempoTotal);
                        Console.WriteLine();
                        Console.WriteLine("El total recaudado fue de: " + sumaFinal);
                        Console.WriteLine();
                        Console.WriteLine("Los tickets creados fueron de: " + ticketsCreados);
                        Console.WriteLine();
                        Console.WriteLine("Los tickets cerrados fueron de: " + ticketsCerrados);
                        break;

                    case 4:
                        Console.WriteLine("Deme el tiempo en minutos (1 - 1440):");
                        int minutos = int.Parse(Console.ReadLine());
                        while (minutos < 1 || minutos > 1440)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error. Ingrese un valor entre 1 y 1440:");
                            Console.ResetColor();
                            minutos = int.Parse(Console.ReadLine());
                        }
                        tiempoSimulado = tiempoTotal + minutos;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Tiempo acumulado: " + tiempoSimulado + " minutos");
                        Console.ResetColor();
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Salir de el menu");
                        Console.ResetColor();
                        break;
                    default:

                        break;
                }
            }while (opcion != 5);
        }
    }
}
