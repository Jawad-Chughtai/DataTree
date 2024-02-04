using DataTree.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using static Volo.Abp.Identity.Settings.IdentitySettingNames;

namespace DataTree.Organizations;

public class EfCoreOrganizationRepository : EfCoreRepository<DataTreeDbContext, Organization, Guid>, IOrganizationRepository
{
    public EfCoreOrganizationRepository(IDbContextProvider<DataTreeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public async Task<Organization?> GetCurrentUserAsync(Guid userId)
    {
        var dbContext = await GetDbContextAsync();

        var organization = await dbContext.Organizations
            .Where(x => x.UserId == userId)
            .Include(x => x.User)
            .FirstOrDefaultAsync();
        return organization;
    }

    public async Task<OrganizationViewModel> GetListAsync(Guid id)
    {
        var dbContext = await GetDbContextAsync();

        var organization = await dbContext.Organizations
            .AsNoTracking()
            .Where(x => x.UserId == id)
            .Include(x => x.User)
            .Select(x => new OrganizationViewModel
            {
                Id = x.Id,
                UserId = x.UserId,
                JobTitle = x.JobTitle,
                ManagerId = x.ManagerId,
                User = x.User
            }).FirstOrDefaultAsync();

        if (organization != null)
        {
            organization.Children = await GetChildrenAsync(organization.Id, dbContext);
        }

        return organization!;
    }

    private async Task<List<OrganizationViewModel>> GetChildrenAsync(Guid parentId, DataTreeDbContext dbContext)
    {
        var children = await dbContext.Organizations
            .Where(x => x.ManagerId == parentId)
            .Select(x => new OrganizationViewModel
            {
                Id = x.Id,
                UserId = x.UserId,
                JobTitle = x.JobTitle,
                ManagerId = x.ManagerId,
                User = x.User
            })
            .ToListAsync();

        foreach (var child in children)
        {
            child.Parent = await dbContext.Organizations.Select(x => new OrganizationViewModel
            {
                Id = x.Id,
                UserId = x.UserId,
                JobTitle = x.JobTitle,
                ManagerId = x.ManagerId,
                User = x.User
            }).FirstOrDefaultAsync(x => x.Id == parentId);
            child.Children = await GetChildrenAsync(child.Id, dbContext);
        }

        return children;
    }
}
