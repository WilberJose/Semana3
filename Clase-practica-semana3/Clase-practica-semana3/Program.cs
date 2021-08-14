using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_practica_semana3
{
    class Program
    {
        static void Main(string[] args)
        {
            //loops
            loops(); //llamado al metodo loops()
            Console.ReadKey();
        }


        //while
        //evalua la condicion y ejecuta las instrucciones
        //si la condicion es verdadera
        public static void loops()
        {
            int[] nums = new int[3]; //crear un arreglo 

            //llenar arreglo
            nums[0] = 4;
            nums[1] = 22;
            nums[2] = 8;

            //imprimir los numeros utilizando while
            int i = 0, idw = 0;
            Console.WriteLine("IMPIRMIENDO CON WHILE: ");
            while (i < nums.Length)
            {

                Console.WriteLine("Indice {0}: {1}", i, nums[i]);
                i++;
            }

            //impirmir con ciclo doWhile
            //la condicion se evlaua al final
            Console.WriteLine("IMPIRMIENDO CON DO-WHILE: ");
            do
            {
                Console.WriteLine("Indice {0}: {1}", idw, nums[idw]);
                idw++;
            } while (idw < nums.Length);


            //imprimir con ciclo for
            //se comprueba la condicion primero y luego se ejecuta si la condiciones es verdadera
            Console.WriteLine("IMPIRMIENDO CON FOR: ");
            for (int inc = 0; inc < nums.Length; inc++)
            {
                Console.WriteLine("Indice {0}: {1}", inc, nums[inc]);
            }
        }
    }
}
