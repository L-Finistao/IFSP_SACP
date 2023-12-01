using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Entity_Consulta :BaseEntity<int>
    {
       
        public Entity_Consulta() { }
        public Entity_Consulta(int id, Boolean Ativ, Boolean Real, Entity_Agenda agenda, Entity_Usuario pacc) {
            Ativa = Ativ;
            Realizada = Real;
            Agenda = agenda; 
            Paciente = pacc;
        }



        public Boolean? Ativa { get; set; }
        public Boolean? Realizada { get; set; }

        public Entity_Agenda? Agenda { get; set; }
        public Entity_Usuario? Paciente { get; set; }
    }
}
