import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'DataTree',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44362/',
    redirectUri: baseUrl,
    clientId: 'DataTree_App',
    responseType: 'code',
    scope: 'offline_access DataTree',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44362',
      rootNamespace: 'DataTree',
    },
  },
} as Environment;
