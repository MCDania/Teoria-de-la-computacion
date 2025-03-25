 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("BUBBLE SORT");
                Console.WriteLine("Dame la longitud de tu lista: ");
                int n = int.Parse(Console.ReadLine());
                int[] nums = new int[n];

                for(int i=0; i < n; i++)
                {
                    Console.WriteLine("Ingresa un número: ");
                    nums[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("\nProceso:");
                for (int i = 0; i < n - 1; i++) 
                {
                    lista(nums);

                    for (int a = 0; a < n - 1 - i; a++) 
                    {
                        if (nums[a] > nums[a + 1]) 
                        {
                            int temp = nums[a];
                            nums[a] = nums[a + 1];
                            nums[a + 1] = temp;
                        }
                    }
                }

                Console.WriteLine("\nLista ordenada:");
                lista(nums);
            }
            catch
            {
                Console.WriteLine("Error en la ejecución del programa o en los datos ingresados. Intente de nuevo.");
            }
            finally
            {
                Console.ReadLine();
            }
        }
        static void lista(int[] nums)
        {
            foreach (var num in nums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
