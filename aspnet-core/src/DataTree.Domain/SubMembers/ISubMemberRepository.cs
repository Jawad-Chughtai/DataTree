using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace DataTree.SubMembers
{
    public interface ISubMemberRepository : IRepository<SubMember, Guid>
    {
        Task<List<SubMember>> GetListAsync(Guid userId);
    }
}
