using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Validators
{
    public class ValidaAgenda : AbstractValidator<Entity_Agenda>
    {
        public ValidaAgenda() {

            RuleFor(c => c.DataAgenda)
                   .NotEmpty().WithMessage("Por favor informe a Data.")
                   .NotNull().WithMessage("Por favor informe a Data.");
            RuleFor(c => c.IdMedico)
                   .NotEmpty().WithMessage("Por favor informe o Medico.")
                   .NotNull().WithMessage("Por favor informe o Medico.");
            RuleFor(c => c.Vagas)
                     .NotEmpty().WithMessage("Por favor informe a Quantidade de Vagas.")
                   .NotNull().WithMessage("Por favor informe a Quantidade de Vagas.");
            RuleFor(c => c.Vaga_Agendados)
                   .NotEqual(c => c.Vagas).WithMessage("Numero Maximo de Pessoas Atingidas");
        }
    }
}
