using LocalAuthorityInformationServices.SharedKernel.Interfaces;
using OrganisationAdmin.Core.Concretions.Entities.Aggregates;

namespace OrganisationAdmin.Core.Concretions.Services;

public class EditOrganisationViewModelService
{
    private readonly IRepository<Organization> _organisationRepository;

    public EditOrganisationViewModelService
    (
        IRepository<Organization> organisationRepository
    //IRepository<CatalogItem> itemRepository,
    //IUriComposer uriComposer,
    //IBasketQueryService basketQueryService
    )
    {
        _organisationRepository = organisationRepository;
        //_uriComposer = uriComposer;
        //_basketQueryService = basketQueryService;
        //_itemRepository = itemRepository;
    }
}
