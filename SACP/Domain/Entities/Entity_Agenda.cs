using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Entity_Agenda : BaseEntity<int>
    {
        public Entity_Agenda() { }
        public Entity_Agenda(int id, Entity_Usuario_Medico usuario_Medico, DateTime data) {
            IdMedico = usuario_Medico;
            Id = id;
            DataAgenda = data;

        }


        public Entity_Usuario_Medico? IdMedico { get; set; }
        public DateTime? DataAgenda { get; set; }

        public int? Vagas { get; set; }

    }
}
