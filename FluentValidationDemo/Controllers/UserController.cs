using System;
using FluentValidationDemo.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationDemo.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class UserController : ControllerBase
	{
		IMediator _mediator;
		
		public UserController(IMediator mediator)
		{
			_mediator = mediator;
		}
		
		[HttpPost]
		public async Task<IActionResult> Create(CreateUserCommand command)
		{
			var userId = await _mediator.Send(command);
			
			return Ok(userId);
		}
		
	}
}