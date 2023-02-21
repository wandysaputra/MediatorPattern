using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MediatRDemo.Controllers;

public class ContactHandler : IRequestHandler<ContactQuery, Contact?>
{
    private readonly ContactContext _contactContext;

    public ContactHandler(ContactContext contactContext) => _contactContext = contactContext;

    public Task<Contact?> Handle(ContactQuery request, CancellationToken cancellationToken)
    {
        return _contactContext.Contacts.FirstOrDefaultAsync(f => f.Id == request.Id, cancellationToken: cancellationToken);
    }
}