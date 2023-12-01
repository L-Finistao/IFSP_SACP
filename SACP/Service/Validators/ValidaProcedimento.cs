using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Validators
{
    public class ValidaProcedimento : AbstractValidator<Entity_Procedimento>
    {
        public ValidaProcedimento() 
        {
            RuleFor(c => c.Id_Medico)
                .NotEmpty().WithMessage("Por favor informe o Medico.")
                .NotNull().WithMessage("Por favor informe o Medico.");
            RuleFor(c => c.Id_Paciente)
                .NotEmpty().WithMessage("Por favor informe o paciente.")
                .NotNull().WithMessage("Por favor informe o Paciente.");
            RuleFor(c => c.Cid)
                .NotEmpty().WithMessage("Por favor informe o CID.")
                .NotNull().WithMessage("Por favor informe o CID.");
        }
    }
}
