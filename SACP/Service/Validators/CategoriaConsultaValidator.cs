using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Validators
{
    public class CategoriaConsultaValidator : AbstractValidator<CategoriaConsulta>
    {
        public CategoriaConsultaValidator()
        {
            RuleFor(c => c.Codigo)
                .NotEmpty().WithMessage("Por favor informe o Codigo.")
                .NotNull().WithMessage("Por favor informe o Codigo.");

            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor informe o Nome.")
                .NotNull().WithMessage("Por favor informe o Nome.");
        }
    }
}
