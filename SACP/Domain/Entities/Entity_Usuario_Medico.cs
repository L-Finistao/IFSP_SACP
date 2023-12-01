using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Entity_Usuario_Medico : BaseEntity<int>
    {
        public Entity_Usuario_Medico() { }

        public Entity_Usuario_Medico(int id, string? nome, DateTime? dt_nasci, string? telefone_01, string? telefone_02, string? vinculo, string? endereco, string? especialidade, string? codigo)
        {
            Nome = nome;
            Dt_Nasci = dt_nasci;
            Telefone_01 = telefone_01;
            Telefone_02 = telefone_02;
            Vinculo = vinculo;
            Endereco = endereco;
            Codigo = codigo;
            Especialidade = especialidade;
        }


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
