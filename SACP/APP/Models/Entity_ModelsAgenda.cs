using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Models
{
    public class Entity_ModelsAgenda
    {
        public int Id { get; set; }

        public string? Nome_Medico { get; set; }
        public string? Especialidade_Medico { get; set; }
        public string? Nome { get; set; }
        public DateTime? DataAgenda { get; set; }
        public int? Vagas { get; set; }


    }
}
