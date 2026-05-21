using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_02_solo_
{
    
        //Clase parcela
        class Parcela
        {
            public string siembra;
            public int crecimientoActual;
            public int mesesCrecimiento;
            public double ingresos;
            public bool regadaEsteMes;

            //Metodo para asignar cultivo
            public void sembrar(string cultivo)
            {
                siembra = cultivo;
                switch (cultivo.ToLower())
                {
                    case "papa":
                        mesesCrecimiento = 2;
                        crecimientoActual = 0;
                        ingresos = 650;
                        regadaEsteMes = false;
                        break;
                    case "fresa":
                        mesesCrecimiento = 4;
                        crecimientoActual = 0;
                        ingresos = 900;
                        regadaEsteMes = false;
                        break;
                    case "tomate":
                        mesesCrecimiento = 3;
                        crecimientoActual = 0;
                        ingresos = 650;
                        regadaEsteMes = false;
                        break;
                    default:
                        siembra = "vacia";
                        mesesCrecimiento = 0;
                        ingresos = 0;
                        regadaEsteMes = false;
                        break;
                }
            }
        //Menu para el main
        static void EjecutarMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=== MENÚ ===");
            Console.WriteLine("1. Sembrar");
            Console.WriteLine("2. Regar parcela");
            Console.WriteLine("3. Consultar parcela");
            Console.WriteLine("4. Avanzar mes");
            Console.WriteLine("5. Salir");
            Console.ResetColor();
        }
       // double dineroTotal = 0, totalIngresos = 0, totalEgresos = 0;
        //int mesesSimulados = 0, cantidadParcelasembrada = 0, cantidadParcelacosechada = 0, riegosRealizados = 0, parcelasVacias = 0;
        //Case de las opciones 
        //Ejecutar opcion proceso
        static void EjecutarOpcion(int opcion, Parcela[,] parcelas, ref double dineroInicial, ref double totalEgresos, ref double dineroTotal, ref double totalIngresos, ref int riegosRealizados, ref int mesesSimulados, ref int cantidadParcelacosechada, ref int cantidadParcelasembrada, ref int empleados, ref double sueldoXempleado, ref int parcelasVacias, ref int mesesTotales)
        {
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Sembrar");
                    Sembrar(parcelas, ref parcelasVacias, ref cantidadParcelacosechada, ref cantidadParcelasembrada);
                    break;

                case 2:
                    Console.WriteLine("Regar parcela");
                    regar(parcelas, ref dineroInicial, ref totalEgresos, ref riegosRealizados, ref dineroTotal);
                    break;

                case 3:
                    Console.WriteLine("Consultar parcela");
                    consultarParcela(parcelas);
                    break;

                case 4:
                    Console.WriteLine("Avanzar mes");
                    avanzarMes(parcelas, ref empleados, ref mesesSimulados, ref sueldoXempleado, ref dineroTotal, ref dineroInicial, ref cantidadParcelacosechada, ref parcelasVacias, ref totalIngresos, ref totalEgresos, ref mesesTotales);
                    break;

                case 5:
                    Console.WriteLine("Salir");
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opción inválida");
                    Console.ResetColor();
                    break;
            }
        }
        //Proceso para el case 1 en sembrar
        static void Sembrar(Parcela[,] parcelas, ref  int parcelasVacias, ref int cantidadParcelacosechada, ref int cantidadParcelasembrada)
        {
            Console.WriteLine("Ingrese fila:");
            int f = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese columna:");
            int c = int.Parse(Console.ReadLine());

            if (f >= 0 && f < parcelas.GetLength(0) &&
                c >= 0 && c < parcelas.GetLength(1))
            {
                if (parcelas[f, c].siembra == "vacia")
                {
                    Console.WriteLine("Ingrese tipo de siembra (papa, tomate, fresa):");
                    string cultivo = Console.ReadLine().ToLower();
                    if (cultivo == "papa" || cultivo == "fresa" || cultivo == "tomate")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        parcelas[f, c].sembrar(cultivo);
                        Console.WriteLine("Siembra realizada correctamente.");
                        cantidadParcelasembrada++;
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Cultivo inválido. Ingrese de nuevo la posicion");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Esa parcela ya tiene siembra. Coloque una nueva posicion");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Posición fuera del rango.");
                Console.ResetColor();
            }
        }
        //Proceso regar del case 2
        static void regar(Parcela[,] parcelas, ref double dineroInicial, ref double totalEgresos, ref int riegosRealizados, ref double dineroTotal)
        {
            Console.WriteLine("Ingrese que fila desea regar");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine("Ahora su columna");
            int c = int.Parse(Console.ReadLine());
            if (f >= 0 && f < parcelas.GetLength(0) && c >= 0 && c < parcelas.GetLength(1))
            {
                if (parcelas[f, c].siembra == "vacia")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No se puede regar una parcela vacía.");
                    Console.ResetColor();
                }
                else
                {
                    if (parcelas[f, c].regadaEsteMes == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Esta parcela ya fue regada este mes.");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("La parcela sí tiene siembra, se puede regar.");
                        Console.ResetColor();
                        parcelas[f, c].regadaEsteMes = true;
                        dineroTotal -= 40;
                        totalEgresos += 40;
                        Console.WriteLine("Se descontaron Q40.");
                        riegosRealizados++;
                        Console.WriteLine("Tiene un dinero total de: Q" + dineroTotal);
                    }
                }  
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sus datos estan fuera del limite");
                Console.ResetColor();
            }
        }
        //Proceso para consultar la parcela del case 3
        static void consultarParcela(Parcela[,] parcelas)
        {
            Console.WriteLine("Ingrese la fila de la parcela la cual quiere consultar");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la columna que quiere revisar");
            int c = int.Parse(Console.ReadLine());
            if (parcelas[f, c].siembra  == "vacia")
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("la parcela esta disponible para sembrar");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Tipo de cultivo: " + parcelas[f, c].siembra);
                Console.WriteLine("Crecimiento: " + parcelas[f, c].crecimientoActual + " / " + parcelas[f, c].mesesCrecimiento + " meses");
                Console.WriteLine("Su parcela se encuentra regada? " + parcelas[f, c].regadaEsteMes);
                Console.ResetColor();
            }
        }
        //Proceso para avanzar el mes del case 3
        static void avanzarMes(Parcela[,] parcelas, ref int empleados, ref int mesesSimulados, ref double sueldoXempleado, ref double dineroTotal, ref double dineroInicial, ref int cantidadParcelacosechada, ref int parcelasVacias, ref double totalIngresos, ref double totalEgresos, ref int mesesTotales)
        {
            for (int f = 0; f < parcelas.GetLength(0); f++)
            {
                for (int c = 0; c < parcelas.GetLength(1); c++)
                {
                    if (parcelas[f, c].siembra != "vacia")
                    {
                        if (parcelas[f, c].regadaEsteMes == true)
                        {
                            parcelas[f, c].crecimientoActual += 2;
                        }
                        else
                        {
                            parcelas[f, c].crecimientoActual += 1;
                        }
                        if (parcelas[f, c].crecimientoActual >= parcelas[f, c].mesesCrecimiento)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("ALERTA!");
                            Console.ResetColor();
                            Console.WriteLine("La parcela con ubicacion en " + f + ", " + c + parcelas[f, c].siembra + " Ya esta lista para cosechar");
                            dineroTotal += parcelas[f, c].ingresos;
                            totalIngresos = parcelas[f, c].ingresos + parcelas[f, c].ingresos;
                            Console.WriteLine("Su dinero total tras la cosecha es de: " + totalIngresos);
                            cantidadParcelacosechada++;
                            parcelasVacias++;
                            parcelas[f, c].sembrar("vacia");
                            Console.WriteLine("De sus meses totales " + mesesTotales + " lleva " + mesesSimulados);
                        }
                    }
                    parcelas[f, c].regadaEsteMes = false;
                }
            }
            mesesSimulados++;
            mesesTotales--;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("El pago de los empleados sera de " + empleados * sueldoXempleado);
            dineroTotal -= empleados * sueldoXempleado;
            totalEgresos += empleados * sueldoXempleado;
            Console.WriteLine("Su dinero total es de: " + dineroTotal);
            Console.ResetColor();
        }
        static void datosFinales(double dineroTotal, double totalIngresos, double totalEgresos, int mesesSimulados, int cantidadParcelsem, int cantidadParcelcos, int parcelasVacias, int riegosRealizados)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("===== REPORTE FINAL =====");
            Console.WriteLine("Dinero final: Q" + dineroTotal);
            Console.WriteLine("Total de ingresos: Q" + totalIngresos);
            Console.WriteLine("Total de egresos: Q" + totalEgresos);
            Console.WriteLine("Meses simulados: " + mesesSimulados);
            Console.WriteLine("Cantidad de parcelas sembradas: " + cantidadParcelsem);
            Console.WriteLine("Cantidad de cosechas realizadas: " + cantidadParcelcos);
            Console.WriteLine("Cantidad total de riegos realizados: " + riegosRealizados);
            Console.WriteLine("Cantidad de parcelas vacías al finalizar: " + parcelasVacias);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("-Muchas gracias-");
        }
        static void Main(string[] args)
        {
            //Main proyecto 02 
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-Bienvenido a su granja virtual-");
            Console.ResetColor();

            double dineroInicial, sueldoXempleado;
            double dineroTotal = 0, totalIngresos = 0, totalEgresos = 0;

            int empleados, mesesTotales;
            int mesesSimulados = 0, cantidadParcelasembrada = 0, cantidadParcelacosechada = 0, riegosRealizados = 0, parcelaVacia = 0;

            Console.WriteLine("Por favor ingrese el dinero inicial de su granja: (Dinero en quetzales)");
            dineroInicial = double.Parse(Console.ReadLine());

            while (dineroInicial <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error");
                Console.ResetColor();
                Console.WriteLine("Por favor coloque un numero mayor a 0");
                dineroInicial = double.Parse(Console.ReadLine());
            }
            dineroTotal += dineroInicial;

            Console.WriteLine("Ingrese con cuantos empleados cuenta. (Numero entero)");
            empleados = int.Parse(Console.ReadLine());

            while (empleados <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error");
                Console.ResetColor();
                Console.WriteLine("Por favor ingrese un numero realista de empleados");
                empleados = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingrese el sueldo minimo de los empleados. Por favor que sea mayor de Q200.00");
            sueldoXempleado = double.Parse(Console.ReadLine());

            while (sueldoXempleado < 200.00)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error");
                Console.ResetColor();
                Console.WriteLine("Por favor fue pedido para ser mayor de Q200.00");
                sueldoXempleado = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingrese los meses que tendran cultivos");
            mesesTotales = int.Parse(Console.ReadLine());

            while (mesesTotales <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error");
                Console.ResetColor();
                Console.WriteLine("Los meses deben ser mayores a 0");
                mesesTotales = int.Parse(Console.ReadLine());
            }
            //Ingreso de datos en las parcelas
            Console.WriteLine("Ingrese filas:");
            int filas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese columnas:");
            int columnas = int.Parse(Console.ReadLine());

            Parcela[,] parcelas = new Parcela[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    parcelas[i, j] = new Parcela();
                    parcelas[i, j].sembrar("vacia");
                }
            }
            bool salir = false;
            int opcion;
            do
             {
                 EjecutarMenu();
                 opcion = int.Parse(Console.ReadLine());
                 EjecutarOpcion(opcion, parcelas, ref dineroInicial, ref totalEgresos, ref dineroTotal, ref totalIngresos, ref riegosRealizados, ref mesesSimulados, ref cantidadParcelacosechada, ref cantidadParcelasembrada, ref empleados, ref sueldoXempleado, ref parcelaVacia, ref mesesTotales);
                    if (opcion == 5)
                        {
                            salir = true;
                        }
            } while (opcion != 5 && !salir && mesesTotales > 0 && dineroTotal > 0);
            datosFinales(dineroTotal, totalIngresos, totalEgresos, mesesSimulados, cantidadParcelasembrada, cantidadParcelacosechada, parcelaVacia, riegosRealizados);
        } 

    }
}