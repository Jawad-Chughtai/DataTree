import type { EntityDto } from '@abp/ng.core';

export interface OrganizationDto extends EntityDto<string> {
  userId?: string;
  jobTitle?: string;
  managerId?: string;
  user: UserDto;
  children: OrganizationDto[];
  parent: OrganizationDto;
  level: number;
  expand: boolean;
}

export interface UserDto {
  userName?: string;
  name?: string;
  surname?: string;
  email?: string;
}
