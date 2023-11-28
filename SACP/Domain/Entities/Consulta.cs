using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Consulta : BaseEntity<int>
    {
        public Consulta() { }

        public Consulta(int id, DateTime? data_criacao, Agenda? agenda, CategoriaConsulta? categoria_Consulta, Usuario? paciente)
        {
            Data_criacao = data_criacao;
            Agenda = agenda;
            Paciente = paciente;
            Categoria = categoria_Consulta;
        }

        public DateTime? Data_criacao { get; set; }
        public Agenda? Agenda { get; set; }
        public Usuario? Paciente { get; set; }
        public CategoriaConsulta? Categoria { get; set; }

    }
}
