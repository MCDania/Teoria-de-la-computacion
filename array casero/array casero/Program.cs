using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_casero
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingrese la cantidad de números: ");
                int n = int.Parse(Console.ReadLine());
                int[] numeros = new int[n];
                int[] original = new int[n];

                for (int i = 0; i < n; i++)
                {
                    Console.Write("Ingrese un número: ");
                    numeros[i] = int.Parse(Console.ReadLine());
                    original[i] = numeros[i];
                }

                int[] ordenados = new int[n];
                for (int i = 0; i < n; i++)
                {
                    int max = int.MinValue;
                    int index = -1;
                    for (int a = 0; a < n; a++)
                    {
                        if (numeros[a] > max)
                        {
                            max = numeros[a];
                            index = a;
                        }
                    }
                    ordenados[i] = max;
                    numeros[index] = int.MinValue;
                }

                Console.WriteLine("\nArreglo original:");
                foreach (int num in original) Console.Write(num + " ");

                Console.WriteLine("\nArreglo ordenado:");
                foreach (int num in ordenados) Console.Write(num + " ");
            }
            catch
            {
                Console.WriteLine("Error en los datos ingresados o en la ejecución del programa. Intente de nuevo.");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
