using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatRDemo.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ContactsController : ControllerBase
{
    private readonly IMediator _mediator;

    public ContactsController(IMediator mediator) => _mediator = mediator;

    [HttpGet("{Id}")]
    public async Task<IActionResult> GetContact([FromRoute] ContactQuery contactQuery, CancellationToken cancellationToken = default)
    {

        return Ok(await _mediator.Send(contactQuery, cancellationToken));
    }
}