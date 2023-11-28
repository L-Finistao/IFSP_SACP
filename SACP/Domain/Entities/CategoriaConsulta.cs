using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CategoriaConsulta : BaseEntity<int>
    {
        public CategoriaConsulta() { }

        public CategoriaConsulta(int id, string? codigo, string? nome)
        {
            Codigo = codigo;
            Nome = nome;

        }

        public string? Codigo { get; set; }
        public string? Nome { get; set; }
    }
}
