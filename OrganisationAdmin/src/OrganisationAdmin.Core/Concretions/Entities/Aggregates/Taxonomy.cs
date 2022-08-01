//using LocalAuthorityInformationServices.SharedKernel;
//using OrganisationAdmin.Core.Interfaces.Entities.Aggregates;

//namespace OrganisationAdmin.Core.Concretions.Entities.Aggregates;

//public class Taxonomy : EntityBase<string>, ITaxonomy
//{
//    private Taxonomy() { }
//    public Taxonomy(string id, string name, string? vocabulary, string? parent
//        //ICollection<OpenReferralLinktaxonomycollection>? linkTaxonomyCollection
//        //ICollection<OpenReferralService_Taxonomy>? serviceTaxonomyCollection
//        )
//    {
//        Id = id;
//        //LinkTaxonomyCollection = linkTaxonomyCollection;
//        Name = name;
//        //ServiceTaxonomyCollection = serviceTaxonomyCollection;
//        Vocabulary = vocabulary;
//        Parent = parent;

//    }

//    public string Name { get; init; } = default!;
//    public string? Vocabulary { get; init; }
//    public string? Parent { get; init; }
//    public virtual ICollection<OpenReferralLinktaxonomycollection>? LinkTaxonomyCollection { get; init; }
//    //public virtual ICollection<OpenReferralService_Taxonomy>? ServiceTaxonomyCollection { get; init; }

//}
