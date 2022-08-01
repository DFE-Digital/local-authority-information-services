﻿using MediatR;

namespace LocalAuthorityInformationServices.SharedKernel;

public abstract class DomainEventBase : INotification
{
    public DateTimeOffset DateOccurred { get; protected set; } = DateTimeOffset.UtcNow;
}
