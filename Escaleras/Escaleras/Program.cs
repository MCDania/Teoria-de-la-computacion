using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Ingrese el número de escalones: ");
            int n = int.Parse(Console.ReadLine());

            int[] pasos = new int[n];
            int contador = 0; 

            Console.WriteLine("\nCombinaciones:");

            void GenerarPasos(int esc, bool tres)
            {
                if (esc == 0)
                {
                    for (int i = 0; i < contador; i++)
                    {
                        Console.Write(pasos[i] + (i == contador - 1 ? "" : " -> "));
                    }
                    Console.WriteLine(" ");
                    return;
                }

                if (esc >= 1)
                {
                    pasos[contador++] = 1; 
                    GenerarPasos(esc - 1, tres);
                    contador--;
                }

                if (esc >= 2)
                {
                    pasos[contador++] = 2; 
                    GenerarPasos(esc - 2, tres);
                    contador--; 
                }

                if (esc >= 3 && !tres)
                {
                    pasos[contador++] = 3;
                    GenerarPasos(esc - 3, true);
                    contador--;
                }
            }

            GenerarPasos(n, false);
        }
        catch (Exception error)
        {
            Console.WriteLine(error);
            Console.WriteLine("Error en la ejecución del código, intente de nuevo.");
        }
        finally
        {
            Console.ReadLine();
        }
    }
}
