using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Cid : BaseEntity<int>
    {

        public Cid() { }
        public Cid(int id, string? codigo, string? descricao)
        {
            Codigo_CID = codigo;
            Descricao = descricao;

        }
        public string? Codigo_CID { get; set; }
        public string? Descricao { get; set; }
    }
}
