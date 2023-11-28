using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Validators
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
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
        }
    }
}
