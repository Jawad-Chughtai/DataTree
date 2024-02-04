using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace DataTree.Organizations;

public interface IOrganizationRepository : IRepository<Organization, Guid>
{
    Task<Organization?> GetCurrentUserAsync(Guid userId);
    Task<OrganizationViewModel> GetListAsync(Guid id);
}
