import { AuthService } from '@abp/ng.core';
import { Component, OnInit } from '@angular/core';
import { OrganizationDto, OrganizationService } from '@proxy/organizations';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent implements OnInit {
  get hasLoggedIn(): boolean {
    return this.authService.isAuthenticated;
  }

  listOfMapData = [] as OrganizationDto[];

  constructor(private authService: AuthService, private service: OrganizationService) {}

  ngOnInit(): void {
    this.service.create().subscribe();
    this.service.getList().subscribe(response => {
      this.listOfMapData.push(response);
      this.listOfMapData.forEach(item => {
        this.mapOfExpandedData[item.id] = this.convertTreeToList(item);
      });
    });
  }

  mapOfExpandedData: { [key: string]: OrganizationDto[] } = {};

  collapse(array: OrganizationDto[], data: OrganizationDto, $event: boolean): void {
    if (!$event) {
      if (data.children) {
        data.children.forEach(d => {
          const target = array.find(a => a.id === d.id)!;
          target.expand = false;
          this.collapse(array, target, false);
        });
      } else {
        return;
      }
    }
  }

  convertTreeToList(root: OrganizationDto): OrganizationDto[] {
    const stack: OrganizationDto[] = [];
    const array: OrganizationDto[] = [];
    const hashMap = {};
    stack.push({ ...root, level: 0, expand: false });

    while (stack.length !== 0) {
      const node = stack.pop()!;
      this.visitNode(node, hashMap, array);
      if (node.children) {
        for (let i = node.children.length - 1; i >= 0; i--) {
          stack.push({ ...node.children[i], level: node.level! + 1, expand: false, parent: node });
        }
      }
    }

    return array;
  }

  visitNode(
    node: OrganizationDto,
    hashMap: { [key: string]: boolean },
    array: OrganizationDto[]
  ): void {
    if (!hashMap[node.id]) {
      hashMap[node.id] = true;
      array.push(node);
    }
  }

  login() {
    this.authService.navigateToLogin();
  }
}
