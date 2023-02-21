using MediatR;

namespace MediatRDemo.Controllers;

public class ContactQuery : IRequest<Contact?>
{
    public int Id { get; set; }

}