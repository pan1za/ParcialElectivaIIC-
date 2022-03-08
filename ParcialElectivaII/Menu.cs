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
            Console.WriteLine("5. Regresar al menú principal\n");
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
                    crearEstudiante();
                    menuAdmin();
                    break;
                case "2":
                    listaUsuarios();
                    Console.ReadKey();
                    menuAdmin();
                    break;
            }
        }
    }
}
