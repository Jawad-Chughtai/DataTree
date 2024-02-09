using AutoMapper;
using DataTree.Organizations;
using DataTree.SubMembers;
using Volo.Abp.Identity;

namespace DataTree;

public class DataTreeApplicationAutoMapperProfile : Profile
{
    public DataTreeApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Organization, OrganizationDto>();
        CreateMap<OrganizationViewModel, OrganizationDto>();
        CreateMap<IdentityUser, UserDto>();

        CreateMap<SubMember, SubMemberDto>();
    }
}
