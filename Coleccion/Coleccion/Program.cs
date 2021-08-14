using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coleccion
{
    class Program
    {
        static void Main(){

            //Diccionarios
            //tipo de coleccion generica de pares: clave:valor
            //las claves deben ser unicas dentro de una coleccion

            //definir un diccionario
            Dictionary<string, string> Data = new Dictionary<string, string>();

            //agregar elementos al diccionario
            Data.Add("Jose", "Ingeniero");
            Data.Add("Maria", "Profesor");
            Data.Add("Ana", "Doctora");
            Data.Add("Carmen", "Ingeniera");


            //definir un diccionario
            Dictionary<string, float> Products = new Dictionary<string, float>();
            //agregar elementos al diccionario
            Products.Add("Te", 1.15f);
            Products.Add("Soda", 0.75f);
            Products.Add("Leche", 2.75f);

            //leer diccionario y mostrar datos
            foreach (KeyValuePair<string, float> product in Products)
            {
                Console.WriteLine("Key: {0}, Value: {1}", product.Key, product.Value);
            }


            //ordenar diccionario
            //definir diccionario como una lista
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


//ordenar el arreglo
// Array.Sort(notas); //el metodo Sort de la clase Array permite ordenar los elementos de un array unidimensional
//Array.Reverse(notas); //permite invertir los elementos de un array

//recorrer el arreglo de notas
//Console.WriteLine("Array ordenado con el metodo Sort()");
//for (int i = 0; i < notas.Length; i++)
//{
    //Console.WriteLine("Nota {0}: {1}", i, notas[i]); //imprime los valroes
//}

//Console.ReadKey();
        //}
    //}
//}
