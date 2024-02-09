using System;
using System.Collections.Generic;
using System.Text;

namespace DataTree.SubMembers
{
    public class SubMemberDto
    {
        public Guid UserId { get; set; }
        public string MemberNo { get; set; }
        public string MemberId { get; set; }
        public DateTime? Date { get; set; }
        public string ApplicationName { get; set; }
        public string VuinDescription { get; set; }
        public float? Count { get; set; }
        public string Status { get; set; }
    }
}
