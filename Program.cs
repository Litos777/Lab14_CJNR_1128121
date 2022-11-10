using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_CJNR_1128121
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = "";
            bool validar = false;
            do
            {
                while (opcion != "3")
                {
                    Console.WriteLine("Ingrese 1, 2 o 3");
                    opcion = Console.ReadLine();
                    validar = false;
                    switch (opcion)
                    {
                        case "1":
                            bool valFecha = false;
                            Console.WriteLine("Ingrese la fecha en el formato dd/mm/aa");
                            string[] nombreEmpleados = new string[5];
                            DateTime[] fehaEmpleados = new DateTime[5];
                            DateTime fechaActual = DateTime.Today;
                            int[] edad = new int[5];
                            for (int i = 0; i < 5; i++)
                            {
                                Console.Write("Ingrese el nombre del empleado: ");
                                nombreEmpleados[i] = Console.ReadLine();
                                do
                                {
                                    valFecha = false;
                                    try
                                    {
                                        Console.Write("Ingrese la fecha de nacimiento de {0} ", nombreEmpleados[i]);
                                        fehaEmpleados[i] = DateTime.Parse(Console.ReadLine());
                                        if (fechaActual.Month >= fehaEmpleados[i].Month)
                                        {
                                            if (fechaActual.Day >= fehaEmpleados[i].Day)
                                            {
                                                edad[i] = Convert.ToInt32(fechaActual.Year - fehaEmpleados[i].Year);
                                            }
                                            else
                                            {
                                                edad[i] = Convert.ToInt32(fechaActual.Year - fehaEmpleados[i].Year) - 1;
                                            }
                                        }
                                        else
                                        {
                                            edad[i] = Convert.ToInt32(fechaActual.Year - fehaEmpleados[i].Year) - 1;
                                        }
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine("Fecha ingresada incorrecta");
                                        valFecha = true;
                                    }
                                } while (valFecha);
                            }
                            Console.WriteLine("\n");
                            for (int i = 0; i < 5; i++)
                            {
                                Console.WriteLine("La edad de {0} es {1}", nombreEmpleados[i], edad[i]);
                            }
                            break;
                        case "2":
                            string[] puesto = new string[5];
                            double[] salario = new double[5];
                            bool validarSalario = false;
                            for (int i = 0; i < 5; i++)
                            {
                                Console.Write("Ingrese el puesto de la empresa: ");
                                puesto[i] = Console.ReadLine();
                                do
                                {
                                    validarSalario = false;
                                    try
                                    {
                                        Console.Write("Ingrese del salario del puesto {0}: ", puesto[i]);
                                        salario[i] = Convert.ToDouble(Console.ReadLine());
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("Error! Ingrese un salario valio");
                                        validarSalario = true;
                                    }
                                } while (validarSalario);
                            }
                            Console.WriteLine("\n");
                            for (int i = 0; i < 5; i++)
                            {
                                Console.WriteLine("El puesto {0} tiene un salario de Q.{1}", puesto[i], salario[i]);
                            }
                            break;
                        case "3":
                            Console.WriteLine("Fin del programa");
                            break;
                        default:
                            Console.WriteLine("Error, ingrese una opcion valida");
                            opcion = Console.ReadLine();
                            validar = true;
                            break;
                    }
                }
            } while (validar);
            Console.ReadKey();
        }
    }
}
