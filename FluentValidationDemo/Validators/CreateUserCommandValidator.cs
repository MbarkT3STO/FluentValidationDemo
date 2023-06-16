using System;
using FluentValidation;
using FluentValidationDemo.Commands;

namespace FluentValidationDemo.Validators
{
	public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
	{
		public CreateUserCommandValidator()
		{
			RuleFor(x => x.FirstName).NotEmpty().MaximumLength(50).WithMessage("First name is required.");
			RuleFor(x => x.LastName).NotEmpty().MaximumLength(50).WithMessage("Last name is required.");
			RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required.");
		}
	}
}