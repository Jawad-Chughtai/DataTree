using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace DataTree.Organizations;

public class OrganizationDto : EntityDto<Guid>
{
    public Guid UserId { get; set; }

    public string? JobTitle { get; set; }

    public Guid? ManagerId { get; set; }

    public UserDto? User { get; set; }

    public List<OrganizationDto> Children { get; set; } = [];

    public OrganizationDto? Parent { get; set; }

    public int Level { get; set; }

    public bool Expand { get; set; }
}