using System;
using FluentValidation;
using MediatR;

namespace FluentValidationDemo.Commands
{
	public class CreateUserCommand : IRequest<Guid>
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
	}

	public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Guid>
	{
		public CreateUserCommandHandler()
		{
			
		}

		public Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
		{
			return Task.FromResult(Guid.NewGuid());
		}
	}
}