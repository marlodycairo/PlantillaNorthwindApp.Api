using FluentValidation;
using NorthwindApp.Api.Payloads;
using NorthwindApp.Infrastructure.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindApp.Infrastructure.Api.Validators
{
    public class CategoryValidator : AbstractValidator<CategoryPayload>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName)
                .Cascade(CascadeMode.Stop)
                .Length(0, 15)
                .NotNull().WithMessage("debe ingresar el nombre de la categoria.");

            RuleFor(x => x.CategoryName)
                .Cascade(CascadeMode.Stop)
                .Length(0, 15)
                .NotEmpty().WithMessage("Debe ingresar el nombre de la categoria");

            RuleFor(x => x.Description)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("debe incluir la descripcion.");

            RuleFor(x => x.Description)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("debe incluir la descripcion.");

            RuleFor(x => x.Picture)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("Debe ingrese una picture de categoria...");

            RuleFor(x => x.Picture)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Debe ingrese una picture de categoria...");
        }
    }
}
