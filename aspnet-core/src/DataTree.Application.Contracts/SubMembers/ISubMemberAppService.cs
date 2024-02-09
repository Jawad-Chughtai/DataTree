using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataTree.SubMembers
{
    public interface ISubMemberAppService
    {
        Task<List<SubMemberDto>> GetListAsync(Guid userId);
    }
}
