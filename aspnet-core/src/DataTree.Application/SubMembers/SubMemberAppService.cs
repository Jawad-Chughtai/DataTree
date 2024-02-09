using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace DataTree.SubMembers
{
    public class SubMemberAppService( ISubMemberRepository subMemberRepository) : ApplicationService, ISubMemberAppService
    {
        public async Task<List<SubMemberDto>> GetListAsync(Guid userId)
        {
            var member = await subMemberRepository.GetListAsync(userId);
            return ObjectMapper.Map<List<SubMember>, List<SubMemberDto>>(member);
        }
    }
}
