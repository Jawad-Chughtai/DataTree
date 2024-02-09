using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using static Volo.Abp.Identity.Settings.IdentitySettingNames;
using Volo.Abp.Identity;

namespace DataTree.SubMembers
{
    public class SubMember : Entity<Guid>
    {
        public Guid UserId { get; set; }
        public string MemberNo { get; set; }
        public string MemberId { get; set; }
        public DateTime? Date { get; set; }
        public string ApplicationName {  get; set; }
        public string VuinDescription {  get; set; }
        public float? Count {  get; set; }
        public string Status {  get; set; }

        [ForeignKey(nameof(UserId))]
        public IdentityUser? User { get; set; }

    }
}
