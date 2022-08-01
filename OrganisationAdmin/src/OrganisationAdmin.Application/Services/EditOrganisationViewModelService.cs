using LocalAuthorityInformationServices.SharedKernel.Interfaces;
using OrganisationAdmin.Application.Aggregates;

namespace OrganisationAdmin.Application.Services;

public class EditOrganisationViewModelService
{
    private readonly IRepository<Organisation> _organisationRepository;

    public EditOrganisationViewModelService
    (
        IRepository<Organisation> organisationRepository
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
