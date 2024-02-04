using System.Threading.Tasks;

namespace DataTree.Organizations;

public interface IOrganizationAppService
{
    Task CreateAsync();
    Task<OrganizationDto> GetListAsync();
}