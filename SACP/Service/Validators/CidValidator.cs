using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Validators
{
    public class CidValidator : AbstractValidator<Cid>
    {
        public CidValidator()
        {
            RuleFor(c => c.Codigo_CID)
                .NotEmpty().WithMessage("Por favor informe o Codigo do CID.")
                .NotNull().WithMessage("Por favor informe o Codigo do CID.");

            RuleFor(c => c.Descricao)
                .NotEmpty().WithMessage("Por favor informe a descrição.")
                .NotNull().WithMessage("Por favor informe a descrição.");
        }
    }
}
