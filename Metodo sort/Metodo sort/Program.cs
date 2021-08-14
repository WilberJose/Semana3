using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] nombres = { "Leydin", "Dorita", "Yasmin", "Wilber"};

            
            int length = nombres.Length;

            
            Array.Sort(nombres);

            
            Console.WriteLine("Array ordenado:\n");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(nombres[i]);
            }
            Console.ReadKey();
        }
    }
}


