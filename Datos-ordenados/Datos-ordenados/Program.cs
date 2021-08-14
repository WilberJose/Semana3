using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos_ordenados
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Data = new Dictionary<string, string>();
            Data.Add("Dorita", "70 años");
            Data.Add("Leydin", "55 años");
            Data.Add("Yasmin", "35 años");
            Data.Add("Wilber", "19 años");

            Dictionary<string, float> Products = new Dictionary<string, float>();

            Products.Add("Dorita", 70f);
            Products.Add("Leydin", 55f);
            Products.Add("Yasmin", 35f);
            Products.Add("Wilber", 19f);

            foreach (KeyValuePair<string, float> product in Products)
            {
                Console.WriteLine("Key: {0}, Value: {1}", product.Key, product.Value);
            }
            var list = Products.Keys.ToList();
            list.Sort();
            Console.WriteLine("Diccionario ordenado");
            foreach (var item in list)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item, Products[item]);
            }


            Console.ReadKey();
        }
    }
}
