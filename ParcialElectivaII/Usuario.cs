using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialElectivaII
{
    public class Usuario
    {
        public string usuario { get; set; }
        public int codigo { get; set; }

        public Usuario()
        {

        }

        public Usuario(string usuario, int codigo)
        {
            this.usuario = usuario;
            this.codigo = codigo;
        }
    }

    
}
