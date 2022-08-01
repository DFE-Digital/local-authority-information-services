﻿using System.ComponentModel.DataAnnotations.Schema;

namespace LocalAuthorityInformationServices.SharedKernel;

/// <summary>
/// Base types for all Entities which track state using a given Id.
/// </summary>
public abstract class EntityBase<Tid>
{
    public Tid Id { get; set; } = default!;

    public DateTime? Created { get; set; } = default;

    public string? CreatedBy { get; set; } = default;

    public DateTime? LastModified { get; set; } = default;

    public string? LastModifiedBy { get; set; } = default;

    private readonly List<DomainEventBase> _domainEvents = new();

    [NotMapped]
    public IEnumerable<DomainEventBase> DomainEvents => _domainEvents.AsReadOnly();

    protected void RegisterDomainEvent(DomainEventBase domainEvent) => _domainEvents.Add(domainEvent);
    
    internal void ClearDomainEvents() => _domainEvents.Clear();
}
