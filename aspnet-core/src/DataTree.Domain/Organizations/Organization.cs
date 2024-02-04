using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Identity;

namespace DataTree.Organizations;

public class Organization : Entity<Guid>
{
    public Guid UserId { get; set; }

    public string? JobTitle { get; set; }

    public Guid? ManagerId { get; set; }

    [ForeignKey(nameof(UserId))]
    public IdentityUser? User { get; set; }

    public Organization()
    {
        
    }


    public Organization(
        Guid id,
        Guid userid,
        string jobtitle,
        Guid? managerid = null
        ) : base(id)
    {
        UserId = userid;
        JobTitle = jobtitle;
        ManagerId = managerid;
    }
}
