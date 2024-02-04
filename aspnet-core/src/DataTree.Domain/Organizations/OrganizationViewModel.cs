using System;
using System.Collections.Generic;
using Volo.Abp.Identity;

namespace DataTree.Organizations;

public class OrganizationViewModel
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public string? JobTitle { get; set; }

    public Guid? ManagerId { get; set; }

    public IdentityUser? User { get; set; }

    public List<OrganizationViewModel> Children { get; set; } = [];
    public OrganizationViewModel? Parent { get; set; }
}