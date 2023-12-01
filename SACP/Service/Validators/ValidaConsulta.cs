using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Validators
{
    public class ValidaConsulta : AbstractValidator<Entity_Consulta>
    {
        public ValidaConsulta() {

            RuleFor(c => c.Paciente)
    .NotEmpty().WithMessage("Por favor informe o Paciente.")
    .NotNull().WithMessage("Por favor informe o Paciente.");
            RuleFor(c => c.Agenda)
    .NotEmpty().WithMessage("Por favor informe a Agenda.")
    .NotNull().WithMessage("Por favor informe a Agenda.");

        }
    }
}
