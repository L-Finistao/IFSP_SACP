using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Agenda : BaseEntity<int>
    {
        public Agenda() { }

        public Agenda(int id, int? codigo, DateTime data_Efetuva, Medico_Especialidades profissional, int? vagas)
        {
            Codigo = codigo;
            Data_Efetuva = data_Efetuva;
            Profissional = profissional;
            Vagas = vagas;


        }

        public int? Codigo { get; set; }
        public DateTime? Data_Efetuva { get; set; }
        public Medico_Especialidades? Profissional { get; set; }
        public int? Vagas { get; set; }

    }
}
