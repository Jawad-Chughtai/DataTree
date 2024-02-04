using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;

namespace DataTree.Organizations;

public class OrganizationAppService(
    IdentityUserManager identityUserManager,
    IOrganizationRepository organizationRepository
    ) : ApplicationService, IOrganizationAppService
{
    public async Task CreateAsync()
    {
        var any = await organizationRepository.AnyAsync();
        if (!any)
        {
            var organization = await SeedUser("gia", "nilej", "PRESIDENT & CEO");
            organization = await SeedUser("ocsinca", "azol", "MERCHANDISING MGR STAFF", organization.Id);
            await SeedUser("ynali", "ugnimod", "NIGHTS FORKLIFT DRIVER", organization.Id);
            await SeedUser("air", "sav", "FOOD STOCKER", organization.Id);
            await SeedUser("oge", "dnem", "MERCH FOODS MGR DEPT", organization.Id);

            await SeedUser("roadavl", "rimar", "MERCH NIGHTS MGR DEPT", organization.ManagerId);
        }
    }


    private async Task<Organization> SeedUser(string name, string surname, string jobTitle, Guid? managerId = null)
    {
        var user = new IdentityUser(GuidGenerator.Create(), name, $"{name}@datatree.com")
        {
            Name = name,
            Surname = surname
        };

        await identityUserManager.CreateAsync(user, "1q2w3E*");

        var organization = new Organization(GuidGenerator.Create(), user.Id, jobTitle, managerId);

        await organizationRepository.InsertAsync(organization);

        return organization;
    }

    public async Task<OrganizationDto> GetListAsync()
    {
        var userId = CurrentUser?.Id;
        var organization = await organizationRepository.GetListAsync(userId!.Value);
        return ObjectMapper.Map<OrganizationViewModel, OrganizationDto>(organization);
    }

}
