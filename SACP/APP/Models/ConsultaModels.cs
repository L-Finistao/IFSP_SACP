using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Models
{
    public class ConsultaModels
    {
        public DateTime? Data_criacao { get; set; }
        public string? Nome_Profissional { get; set; }  //Nome do Profissional
        public string? Nome_Especialidade { get; set; }  //Nome da especialidade
        public int? IdCodigoAgenda { get; set; }     //ID Da Agenda

        public string? Nome { get; set; } //Nome do Usuario
        public string? Vinculo { get; set; } //Vinculo do Usuario
        public string? Nome_Categoria { get; set; } //Nome_Categoria
    }
}
