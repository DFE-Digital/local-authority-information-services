using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OrganisationAdmin.Core.Interfaces.Services.Domain;

namespace OrganisationAdmin.WebUiRazor.Pages
{
    public class FindServiceFromPostcodePageModel : PageModel
    {
        private readonly IPostcodeLocationClientService _postcodeLocationClientService;
        public string Postcode { get; set; } = default!;

        public FindServiceFromPostcodePageModel(IPostcodeLocationClientService postcodeLocationClientService)
        {
            _postcodeLocationClientService = postcodeLocationClientService;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            var postCode = Request.Form["Postcode"];

            if (string.IsNullOrEmpty(postCode))
            {
                return new RedirectToPageResult("/FindServiceFromPostcode");
            }

            // ToDo:
            // PostcodeApiModel postcodeApiModel = await _postcodeLocationClientService.LookupPostcode(postCode);


            return RedirectToPage("LocalOfferResults", new
            {
                // ToDo:
                //postcodeApiModel.result.latitude,
                //postcodeApiModel.result.longitude,
                distance = 32186.9 //212892.0
            });

            //return new RedirectToPageResult($"/LocalOfferResults/{lat}/{lng}");
        }
    }
}
