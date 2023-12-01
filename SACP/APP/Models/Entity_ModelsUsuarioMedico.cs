using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Models
{
    public class Entity_ModelsUsuarioMedico
    {
        public int Id { get; set; }

        public string? Nome { get; set; }
        public string? Endereco { get; set; }

        public string? Codigo { get; set; }
        public string? Especialidade { get; set; }


        public DateTime? Dt_Nasci { get; set; }
        public string? Telefone_01 { get; set; }
        public string? Telefone_02 { get; set; }
        public string? Vinculo { get; set; }
    }
}
