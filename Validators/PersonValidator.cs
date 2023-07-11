using FluentValidation;
using Ornekapi.Models;

namespace Ornekapi.Validators;

public class PersonValidator : AbstractValidator<Person>
{
    public PersonValidator()
    {
        RuleFor(person => person.Name)
        .NotEmpty()
        .WithMessage("Staff person name")
        .Length(5,100);

        RuleFor(person => person.LastName)
        .NotEmpty()
        .WithMessage("Staff person lastname")
        .Length(5,100);

        RuleFor(person => person.Phone)
        .Matches(@"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$")
        .NotEmpty()
        .WithMessage("Staff person phone number");

        RuleFor(person => person.AccessLevel)
        .NotEmpty()
        .WithMessage("Staff person access level to system")
        .GreaterThanOrEqualTo(1)
        .LessThanOrEqualTo(5);

        RuleFor(person => person.Salary)
        .NotEmpty()
        .WithMessage("Staff person salary")
        .GreaterThanOrEqualTo(5000)
        .LessThanOrEqualTo(50000);

    }
}