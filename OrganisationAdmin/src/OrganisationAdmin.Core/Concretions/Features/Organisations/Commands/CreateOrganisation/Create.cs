using OrganisationAdmin.Core.Interfaces.Entities.Aggregates;
using MediatR;

namespace OrganisationAdmin.Core.Concretions.Features.Organisations.Commands.CreateOrganisation;

public class Create : IRequest<string>
{
    public IOrganization Organisation { get; init; }

    public Create(IOrganization organisation)
    {
        Organisation = organisation;
    }

}

public class CreateOrganisationCommandHandler : IRequestHandler<Create, string>
{
    //private readonly ILAHubDbContext _context;

    //public CreateOrganisationCommandHandler(ILAHubDbContext context)
    //{
    //    _context = context;
    //}
    //public async Task<string> Handle(Create request, CancellationToken cancellationToken)
    //{
    //    var entity = request.Organisation;

    //    try
    //    {
    //        entity.AddDomainEvent(new rganisationCreatedEvent(entity));

    //        _context.OpenReferralOrganisations.Add(entity);

    //        await _context.SaveChangesAsync(cancellationToken);
    //    }
    //    catch (Exception ex)
    //    {
    //        throw new Exception(ex.Message, ex);
    //    }

    //    if (entity is not null)
    //        return entity.Id;
    //    else
    //        return string.Empty;
    //}
    public Task<string> Handle(Create request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
