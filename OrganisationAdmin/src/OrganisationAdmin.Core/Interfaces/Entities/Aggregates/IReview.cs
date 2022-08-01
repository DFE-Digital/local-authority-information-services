namespace OrganisationAdmin.Core.Interfaces.Entities.Aggregates
{
    public interface IReview
    {
        DateTime Date { get; init; }
        string? Description { get; init; }
        string? Score { get; init; }
        string Title { get; init; }
        string? Url { get; init; }
        string? Widget { get; init; }
    }
}