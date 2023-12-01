using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Validators
{
    public class ValidaMedico : AbstractValidator<Entity_Usuario_Medico>
    {
        public ValidaMedico()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.");

            RuleFor(c => c.Dt_Nasci)
                .NotEmpty().WithMessage("Por favor informe a data de nascimento.")
                .NotNull().WithMessage("Por favor informe a data de nascimento.");

            RuleFor(c => c.Vinculo)
                .NotEmpty().WithMessage("Por favor informe o vinculo.")
                .NotNull().WithMessage("Por favor informe o vinculo.");
        
            RuleFor(c => c.Codigo)
                 .NotEmpty().WithMessage("Por favor informe o Codigo.")
                .NotNull().WithMessage("Por favor informe o Codigo.");

            RuleFor(c => c.Especialidade)
                 .NotEmpty().WithMessage("Por favor informe a Especialidade.")
                .NotNull().WithMessage("Por favor informe a Especialidade.");
        }

    }
}
