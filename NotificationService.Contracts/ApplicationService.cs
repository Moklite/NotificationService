using Microsoft.EntityFrameworkCore;
using NotificationService.Contracts.Commons;
using NotificationService.Entities;
using NotificationService.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService.Contracts
{
    public class ApplicationService : IApplication
    {
        private readonly AppDBContext _context;

        public ApplicationService(AppDBContext context)
        {
            _context = context;
        }

        public async Task CreateApplication(Application application)
        {
            application.UniqueKey = TokenGenerator.GetUniqueKey();
            _context.Add(application);
            await _context.SaveChangesAsync();
        }
    

        public async Task DeleteApplication(Application application)
        {
            _context.Remove(application);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Application>> GetAllApplications()
        {
            return await _context.Applications
                .OrderBy(c => c.Id)
                .ToListAsync();
        }

        public async Task<Application> GetApplication(int Id)
        {
           return await _context.Applications
                .SingleOrDefaultAsync(c => c.Id.Equals(Id));
        }

        public async Task UpdateApplication(Application application)
        { 
            _context.Update(application);
            await _context.SaveChangesAsync();
        }
    }
}
