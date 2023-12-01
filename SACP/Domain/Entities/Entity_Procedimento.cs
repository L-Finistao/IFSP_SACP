using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Entity_Procedimento : BaseEntity<int>
    {

        public Entity_Procedimento() { }

        public Entity_Procedimento(int id, string? cid, string? desc, DateTime data, Entity_Usuario_Medico medic, Entity_Usuario paci) {
            Cid = cid;
            Descricao = desc;
            Data_Agendado = data;
            Id_Medico = medic;
            Id_Paciente = paci;
        }

        public string? Cid { get; set; }
        public string? Descricao { get; set; }
        public DateTime Data_Agendado { get; set; }
        
        public Entity_Usuario_Medico Id_Medico { get; set; }
        public Entity_Usuario Id_Paciente { get; set; }
    }
}
