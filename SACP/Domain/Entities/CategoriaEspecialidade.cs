using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CategoriaEspecialidade : BaseEntity<int>
    {
        public CategoriaEspecialidade() { }

        public CategoriaEspecialidade(int id, string? nome, string? codigo)
        {
            Nome = nome;
            Codigo = codigo;
        }

        public string? Nome { get; set; }
        public string? Codigo { get; set; }

    }
}
