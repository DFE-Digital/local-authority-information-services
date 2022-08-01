//using LocalAuthorityInformationServices.SharedKernel;
//using LocalAuthorityInformationServices.SharedKernel.Interfaces;

//namespace OrganisationAdmin.Core.Concretions.Entities;

//public class Contact : EntityBase<string>, IAggregateRoot
//{
//    public string Name { get; init; } = default!;

//    public string Title { get; init; } = default!;


//    private Contact() { }
//    public Contact(string id, string title, string name, ICollection<OpenReferralPhone>? phones)
//    {
//        Id = id;
//        Title = title;
//        Name = name;
//        Phones = phones;
//    }


//    public virtual ICollection<OpenReferralPhone>? Phones { get; init; }

//}
