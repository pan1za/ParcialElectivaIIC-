using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialElectivaII
{
    public class Crud
    {
        List<Usuario> datasetUsuario = new List<Usuario>();
        string usuario;
        int codigo;
        public void crearEstudiante()
        {
            Console.WriteLine("Usuario");
            usuario = Console.ReadLine();
            Console.WriteLine("Codigo");
            codigo = Convert.ToInt32(Console.ReadLine());

            datasetUsuario.Add(new Usuario(usuario, codigo));
            Console.Clear();
            Console.WriteLine("\nUsuario guardado");
        }

        private bool listaVaciaEst()
        {
            if (datasetUsuario.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void listaUsuarios()
        {
            if (listaVaciaEst() == true)
            {
                Console.WriteLine("No se encuentra ningun usuario en la  lista");
            }
            else
            {
                Console.WriteLine("Total de registros de usuarios en la lista: " + datasetUsuario.Count);
                Console.WriteLine("------------------------LISTA------------------------");

                foreach (Usuario item in datasetUsuario)
                {
                    Console.WriteLine("Usuario: {0} | Codigo: {1}",
                        item.usuario, item.codigo);

                }
            }
            Console.WriteLine("\n");
        }
    }
}
