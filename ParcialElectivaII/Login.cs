using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialElectivaII
{
    public class Login : Menu
    {
        string userIngresado;
        int codigoIngresado;
        public void iniciarLogin()
        {
            login();
        }

        public void login()
        {
            Console.Clear();
            Console.Clear();
            Console.WriteLine("       ******  BIENVENIDO  ******");
            Console.WriteLine("----------------------------------------\n");
            Console.WriteLine("POR FAVOR INICIE SESIÓN\n");
            Console.WriteLine("Usuario: ");
            userIngresado = Console.ReadLine();
            Console.WriteLine("Codigo: ");
            codigoIngresado = Convert.ToInt32(Console.ReadLine());
            verificarLogin(userIngresado, codigoIngresado);
        }
        
        public void verificarLogin(string user, int cod)
        {
            if (user == "admin" && cod == 1)
            {
                menuAdmin();
            }
            else
            {
                if (user != "admin")
                {
                    Console.WriteLine("\nUsuario incorrecto");
                    Console.ReadKey();
                    login();
                }
                else
                {
                    if (cod != 1)
                    {
                        Console.WriteLine("\nCodigo incorrecto");
                        Console.ReadKey();
                        login();
                    }
                }
            }
        }
    }
}
