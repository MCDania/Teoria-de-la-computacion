using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayúsculas_a_minúsculas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("\nMayúsculas y/o minúsculas");
                    Console.WriteLine("1. Convertir a MAYÚSCULAS");
                    Console.WriteLine("2. Convertir a minúsculas");
                    Console.WriteLine("3. Combinado");
                    Console.WriteLine("4. Salir");
                    Console.Write("Selecciona una opción: ");

                    int op = int.Parse(Console.ReadLine());

                    if (op == 4)
                    {
                        return;
                    }
                    else if (op >= 5)
                    {
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        Console.ReadLine();
                        return;
                    }

                    Console.Write("\nIngresa el texto: ");
                    string texto = Console.ReadLine();

                    switch (op)
                    {
                        case 1:
                            texto = texto.ToUpper();
                            Console.WriteLine(texto);
                            break;
                        case 2:
                            texto = texto.ToLower();
                            Console.WriteLine(texto);
                            break;
                        case 3:
                            string res = "";
                            char[] chars = texto.ToCharArray();
                            for (int i = 0; i < chars.Length; i++)
                            {
                                if (i % 2 == 0)
                                    chars[i] = char.ToUpper(chars[i]);
                                else
                                    chars[i] = char.ToLower(chars[i]);
                            }
                            res = new string(chars);

                            Console.WriteLine(res);
                            break;
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error en los datos ingresados.");
                Console.WriteLine(error.ToString());
                Console.ReadLine();
            }
        }
    }
}
