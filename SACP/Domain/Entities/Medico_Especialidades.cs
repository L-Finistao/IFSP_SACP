using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Medico_Especialidades : BaseEntity<int>
    {
        public Medico_Especialidades() { }

        public Medico_Especialidades(int id, Usuario_Medico? idmedico, CategoriaEspecialidade? categoria_Especialidade)
        {
            IdMedico = idmedico;
            Categoria_Especialidade = categoria_Especialidade;

        }

        public Usuario_Medico? IdMedico { get; set; }
        public CategoriaEspecialidade? Categoria_Especialidade { get; set; }
    }
}
