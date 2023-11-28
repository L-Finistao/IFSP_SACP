using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.infra
{
    public class AgendaModel
    {
        public int? Codigo { get; set; }
        public DateTime? Data_Efetuva { get; set; }
        public string? Nome_Profissional { get; set; }  //Nome do Profissional
        public string? Nome_Especialidade { get; set; }  //Nome da especialidade
        public int? Vagas { get; set; }

    }
}
