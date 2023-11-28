using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Usuario_Medico : BaseEntity<int>
    {
        public Usuario_Medico() { }

        public Usuario_Medico(int id, Usuario? usuario)
        {
            UsuarioMedico = usuario;
        }

        public Usuario? UsuarioMedico { get; set; }

    }
}
