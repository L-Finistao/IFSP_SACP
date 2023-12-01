using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Models
{
    public class Entity_ModelsProcedimento
    {
        public int Id { get; set; }

        public string? Cid { get; set; }
        public string? Descricao { get; set; }
        public DateTime Data_Agendado { get; set; }
        public string? Nome_Medico{ get; set; }
        public string? Especialidade_Medico{ get; set; }

        public string? Nome_Paciente { get; set; }
        public string? Vinculo_Paciente { get; set; }
    }
}
