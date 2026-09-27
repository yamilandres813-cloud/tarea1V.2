using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continuar = "S";

            while (continuar == "S")
            {
                string numero_cedula = "";
                string nombre_empleado = "";
                int tipo_empleado = 0;
                int horas_laboradas = 0;
                int precio_hora = 3000;
                int aumento = 0;

                Console.WriteLine("Digite su cedula:");
                numero_cedula = Console.ReadLine();

                Console.WriteLine("Escriba su nombre:");
                nombre_empleado = Console.ReadLine();

                Console.WriteLine("Digite las horas laboradas:");
                horas_laboradas = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite el numero del tipo de empleado:" +
                    " (1 = Operario, 2 = Tecnico, 3 = Profesional)");
                tipo_empleado = int.Parse(Console.ReadLine());

                int salario_ordinario = horas_laboradas * precio_hora;

                if (tipo_empleado == 1)
                {
                    aumento = (int)(salario_ordinario * 0.15);
                }
                else if (tipo_empleado == 2)
                {
                    aumento = (int)(salario_ordinario * 0.10);
                }
                else if (tipo_empleado == 3)
                {
                    aumento = (int)(salario_ordinario * 0.05);
                }
                else
                {
                    Console.WriteLine("Error: numero inexistente.");
                    continue;
                }

                int salario_bruto = salario_ordinario + aumento;

                double deduccion_CCSS = salario_bruto * 0.0917;

                double salario_neto = salario_bruto - deduccion_CCSS;

                Console.WriteLine("--- INFORMACION DEL EMPLEADO ---");
                Console.WriteLine("Cedula: " + numero_cedula);
                Console.WriteLine("Nombre: " + nombre_empleado);
                Console.WriteLine("Tipo de empleado: " + tipo_empleado);
                Console.WriteLine("Salario por hora: " + precio_hora);
                Console.WriteLine("Cantidad de horas laboradas: " + horas_laboradas);
                Console.WriteLine("Salario ordinario: " + salario_ordinario);
                Console.WriteLine("Aumento: " + aumento);
                Console.WriteLine("Salario bruto: " + salario_bruto);
                Console.WriteLine("Deduccion de CCSS: " + deduccion_CCSS);
                Console.WriteLine("Salario neto: " + salario_neto);

                // Preguntar si desea continuar
                do
                {
                    Console.WriteLine("\n¿Desea ingresar otro empleado? (S/N)");
                    continuar = Console.ReadLine().ToUpper();

                    if (continuar != "S" && continuar != "N")
                    {
                        Console.WriteLine("Error: debe ingresar solamente S o N.");
                    }

                } while (continuar != "S" && continuar != "N");
            }

            Console.WriteLine("\nPrograma finalizado.");
        }
    }

}
                