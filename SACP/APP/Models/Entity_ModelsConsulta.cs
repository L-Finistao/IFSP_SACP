using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Models
{
    public class Entity_ModelsConsulta
    {
        public int Id { get; set; }

        public Boolean? Ativa { get; set; }
        public Boolean? Realizada { get; set; }

        public int? IdMedico { get; set; }
        public int? IdPaciente { get; set; }

        public string? Nome_Medico { get; set; }
        public string? Especialidade_Medico { get; set; }
        public string? Nome_Agenda { get; set; }
        public DateTime? DataAgenda { get; set; }
        public int? Vagas { get; set; }

        public string? Nome { get; set; }
        public string? Vinculo { get; set; }

        public string? Periodo_Consulta { get; set; }

    }
}
