using System;

namespace ProjectManagement.Service.Contracts
{
    public interface IServiceManager
    {
        IProjectService ProjectService { get; }
    }
}