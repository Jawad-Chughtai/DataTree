using DataTree.EntityFrameworkCore;
using DataTree.Organizations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace DataTree.SubMembers
{
    public class EfCoreSubMemberRepository : EfCoreRepository<DataTreeDbContext, SubMember, Guid>, ISubMemberRepository
    {
        public EfCoreSubMemberRepository(IDbContextProvider<DataTreeDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<List<SubMember>> GetListAsync(Guid userId)
        {
            var dbContext = await GetDbContextAsync();

            var members = await dbContext.SubMembers.Where(x => x.UserId == userId)
                .Select(x => new SubMember
                {
                    UserId = x.UserId,
                    MemberId = x.MemberId,
                    MemberNo = x.MemberNo,
                    Date = x.Date,
                    ApplicationName = x.ApplicationName,
                    VuinDescription = x.VuinDescription,
                    Count = x.Count,
                    Status = x.Status,
                }).ToListAsync();

            return members;
        }
    }
}
