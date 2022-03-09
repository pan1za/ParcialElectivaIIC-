using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialElectivaII
{
    public class Menu : Crud
    {
        string opcMenuAdmin;
        public void menuAdmin()
        {
            Console.Clear();
            Console.WriteLine("       ******  BIENVENIDO ADMINISTRADOR  ******");
            Console.WriteLine("\n¿QUÉ DESEA HACER?");
            Console.WriteLine("\n1. Crear usuarios");
            Console.WriteLine("2. Listar usuarios");
            Console.WriteLine("3. Crear blogs de acuerdo al usuario");
            Console.WriteLine("4. Listar blogs de acuerdo al usuario");
            Console.WriteLine("5. Salir\n");
            opcMenuAdmin = Console.ReadLine();
            selecMenuAdmin(opcMenuAdmin);
        }

        public void selecMenuAdmin(string opc)
        {
            if (opc == "")
                menuAdmin();
            switch (opc)
            {
                case "1":
                    Console.Clear();
                    crearUsuario();
                    menuAdmin();
                    break;
                case "2":
                    Console.Clear();
                    listaUsuarios();
                    Console.ReadKey();
                    menuAdmin();
                    break;
                case "3":
                    Console.Clear();
                    int select = seleccioneUsuario();
                    if  (select == 0)
                    {
                        Console.WriteLine("\nIngrese un codigo valido");
                        Console.ReadKey();
                        Console.Clear();
                        menuAdmin();
                    }
                    else
                    {
                        crearBlog(select);
                        menuAdmin();
                    }
                    break;
                case "4":
                    Console.Clear();
                    listaBlogs(seleccioneUsuario());
                    menuAdmin();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Seleccione una opción correcta, presione cualquier tecla");
                    Console.ReadKey();
                    menuAdmin();
                    break;
            }
        }
    }
}
