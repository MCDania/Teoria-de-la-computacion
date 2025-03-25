using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contraseña
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Crea una contraseña segura, debe contener:" +
                    "\n* 8 caracteres mínimo \n* Al menos una letra mayúscula \n* Al menos una letra minúscula" +
                    "\n* Al menos un número \n* Al menos un caracter especial \n");
                string password = Console.ReadLine();

                if (password.Length == 0)
                {
                    Console.WriteLine("Por favor ingresa una contraseña.");
                }
                else if (password.Length < 8)
                {
                    Console.WriteLine("Debe contener al menos 8 caracteres.");
                }
                else
                {
                    bool tieneMayuscula = false, tieneMinuscula = false, tieneNumero = false, tieneEspecial = false;

                    foreach (char c in password)
                    {
                        if (char.IsUpper(c)) tieneMayuscula = true;
                        else if (char.IsLower(c)) tieneMinuscula = true;
                        else if (char.IsDigit(c)) tieneNumero = true;
                        else if (!char.IsLetterOrDigit(c)) tieneEspecial = true;
                        else if (char.IsWhiteSpace(c))
                        {
                            Console.WriteLine("La contraseña no debe contener espacios.");
                            return;
                        }
                    }

                    if (tieneMayuscula && tieneMinuscula && tieneNumero && tieneEspecial)
                    {
                        Console.WriteLine("La contraseña es segura.");
                    }
                    else
                    {
                        Console.WriteLine("La contraseña no cumple con los requisitos de seguridad.");
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error en datos ingresados.");
                Console.WriteLine(error);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
