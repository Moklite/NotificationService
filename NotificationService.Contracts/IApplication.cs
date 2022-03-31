using NotificationService.Entities.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NotificationService.Contracts
{
    public interface IApplication
    {
        Task<IEnumerable<Application>> GetAllApplications();
        Task<Application> GetApplication(int Id);
        Task CreateApplication(Application application);
        Task UpdateApplication(Application application);
        Task DeleteApplication(Application application);
    }
}
