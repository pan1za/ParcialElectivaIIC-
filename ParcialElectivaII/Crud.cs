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
        List<Blogs> datasetBlog = new List<Blogs>();
        string usuario, nombreBlog;
        int codigo, blogID, codigoUsuario;

        public void crearUsuario()
        {
            Console.WriteLine("Usuario: ");
            usuario = Console.ReadLine();
            Console.WriteLine("\nCodigo: ");
            codigo = Convert.ToInt32(Console.ReadLine());

            datasetUsuario.Add(new Usuario(usuario, codigo));
            Console.WriteLine("\nUsuario guardado");
            Console.ReadKey();
        }

        private bool listaVaciaUser()
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
            if (listaVaciaUser() == true)
            {
                Console.WriteLine("No se encuentra ningun usuario en la  lista");
            }
            else
            {
                //Console.WriteLine("Total de registros de usuarios en la lista: " + datasetUsuario.Count);
                Console.WriteLine("------------------------LISTA DE USUARIOS------------------------");

                foreach (Usuario item in datasetUsuario)
                {
                    Console.WriteLine("Usuario: {0} | Codigo: {1}",
                        item.usuario, item.codigo);

                }
            }
            Console.WriteLine("\n");
        }

        //////////////////////////////////////////////////////////

        int contadorBlogID = 1;

        public int seleccioneUsuario()
        {
            listaUsuarios();
            Console.WriteLine("Escriba el codigo del usuario: ");
            int codSelec;
            string cod = Console.ReadLine();
            int n;
            bool result = Int32.TryParse(cod, out n);
            if (result)
            {
                codSelec = Convert.ToInt32(cod);
            }
            else
            {
                return 0;
            }

            return codSelec;
        }
        public void crearBlog(int codUsu)
        {
            bool existe = false;
            if (!listaVaciaUser())
            {
                foreach (Usuario item in datasetUsuario)
                {
                    if (item.codigo == codUsu) { 
                        existe = true;
                        break;
                    }
                }
                if (existe)
                {
                    blogID = contadorBlogID;
                    contadorBlogID++;
                    Console.WriteLine("\nNombre del blog: ");
                    nombreBlog = Console.ReadLine();
                    codigoUsuario = codUsu;

                    datasetBlog.Add(new Blogs(blogID, nombreBlog, codigoUsuario));
                    Console.WriteLine("\nBlog guardado con ID "+blogID);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("El usuario no existe");
                    Console.ReadKey();
                }
                
            }
        }

        private bool listaVaciaBlog()
        {
            if (datasetBlog.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void listaBlogs(int codigoUsuario)
        {
            if (listaVaciaBlog() == true)
            {
                Console.WriteLine("No se encuentra ningun blog en la lista");
            }
            else
            {
                Console.WriteLine("------------------------LISTA DE BLOGS------------------------");
                foreach (Blogs item in datasetBlog)
                {
                    if (item.codigoUsuario == codigoUsuario)
                    {
                        Console.WriteLine("BlogID: {0} | Nombre del blog: {1} | Codigo Usuario: {2}",
                        item.blogID, item.nombreBlog, item.codigoUsuario);
                    }
                    

                }
            }
            Console.ReadKey();
        }

    }
}
