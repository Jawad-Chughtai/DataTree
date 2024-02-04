import type { OrganizationDto } from './models';
import { RestService, Rest } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class OrganizationService {
  apiName = 'Default';
  

  create = (config?: Partial<Rest.Config>) =>
    this.restService.request<any, void>({
      method: 'POST',
      url: '/api/app/organization',
    },
    { apiName: this.apiName,...config });
  

  getList = (config?: Partial<Rest.Config>) =>
    this.restService.request<any, OrganizationDto>({
      method: 'GET',
      url: '/api/app/organization',
    },
    { apiName: this.apiName,...config });

  constructor(private restService: RestService) {}
}
