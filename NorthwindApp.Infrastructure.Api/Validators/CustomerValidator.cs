using FluentValidation;
using NorthwindApp.Infrastructure.Api.Payloads;

namespace NorthwindApp.Infrastructure.Api.Validators
{
    public class CustomerValidator : AbstractValidator<CustomerPayload>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.CompanyName)
                .Cascade(CascadeMode.Stop)
                .Length(0, 40)
                .NotNull();

            RuleFor(x => x.CompanyName)
                .Cascade(CascadeMode.Stop)
                .Length(0, 40)
                .NotEmpty();

            RuleFor(x => x.ContactName)
                .Cascade(CascadeMode.Stop)
                .Length(0, 30)
                .NotNull();

            RuleFor(x => x.ContactName)
                .Cascade(CascadeMode.Stop)
                .Length(0, 30)
                .NotEmpty();

            RuleFor(x => x.ContactTitle)
                .Cascade(CascadeMode.Stop)
                .Length(0, 30)
                .NotNull();

            RuleFor(x => x.ContactTitle)
                .Cascade(CascadeMode.Stop)
                .Length(0, 30)
                .NotEmpty();

            RuleFor(x => x.Address)
                .Cascade(CascadeMode.Stop)
                .Length(0, 60)
                .NotNull();

            RuleFor(x => x.Address)
                .Cascade(CascadeMode.Stop)
                .Length(0, 60)
                .NotEmpty();

            RuleFor(x => x.City)
                .Cascade(CascadeMode.Stop)
                .Length(0, 15)
                .NotNull();

            RuleFor(x => x.City)
                .Cascade(CascadeMode.Stop)
                .Length(0, 15)
                .NotEmpty();

            RuleFor(x => x.Region)
                .Cascade(CascadeMode.Stop)
                .Length(0, 15)
                .NotNull();

            RuleFor(x => x.Region)
                .Cascade(CascadeMode.Stop)
                .Length(0, 15)
                .NotEmpty();

            RuleFor(x => x.PostalCode)
                .Cascade(CascadeMode.Stop)
                .Length(0, 10)
                .NotNull();

            RuleFor(x => x.PostalCode)
                .Cascade(CascadeMode.Stop)
                .Length(0, 10)
                .NotEmpty();

            RuleFor(x => x.Country)
                .Cascade(CascadeMode.Stop)
                .Length(0, 15)
                .NotNull();

            RuleFor(x => x.Country)
                .Cascade(CascadeMode.Stop)
                .Length(0, 15)
                .NotEmpty();

            RuleFor(x => x.Phone)
                .Cascade(CascadeMode.Stop)
                .Length(0, 24)
                .NotNull();

            RuleFor(x => x.Phone)
                .Cascade(CascadeMode.Stop)
                .Length(0, 24)
                .NotEmpty();

            RuleFor(x => x.Fax)
                .Cascade(CascadeMode.Stop)
                .Length(0, 24)
                .NotNull();

            RuleFor(x => x.Fax)
                .Cascade(CascadeMode.Stop)
                .Length(0, 24)
                .NotEmpty();
        }
    }
}
