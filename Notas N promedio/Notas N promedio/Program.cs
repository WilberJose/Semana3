using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas_N_promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======Promedio de notas=======");
            Console.WriteLine("");

            string alumno;
            int nota1, nota2, nota3;

            Console.Write("Ingrese el nombre del alumno ");

            alumno = Console.ReadLine();

            Console.Write("Ingresa la nota 1: ");
            nota1 = int.Parse(Console.ReadLine());

            Console.Write("Ingresa la nota 2: ");
            nota2 = int.Parse(Console.ReadLine());

            Console.Write("Ingresa la nota 3: ");
            nota3 = int.Parse(Console.ReadLine());

            double promedio = (nota1 + nota2 + nota3) / 3.0;

            Console.WriteLine("--------------------");
            Console.WriteLine("El promedio del alumno es: " + promedio.ToString("0.00"));


            Console.ReadKey();
        }
    }
}