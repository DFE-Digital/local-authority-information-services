﻿using System.Threading.Tasks;

namespace LocalAuthorityInformationServices.SharedKernel.Interfaces
{
    public interface IHandle<T> where T : BaseDomainEvent
    {
        Task HandleAsync(T args);
    }
}
