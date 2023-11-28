using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Procedimento : BaseEntity<int>
    {
        public Procedimento() { }

        public Procedimento(int id, Cid? cid, Medico_Especialidades? profissional)
        {
            Cid = cid;
            Profissional = profissional;
        }

        public Cid? Cid { get; set; }
        public Medico_Especialidades? Profissional { get; set; }

    }
}
