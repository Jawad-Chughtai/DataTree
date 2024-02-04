import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';
import { HomeRoutingModule } from './home-routing.module';
import { HomeComponent } from './home.component';
import { NzTableModule } from 'ng-zorro-antd/table';

@NgModule({
  declarations: [HomeComponent],
  imports: [SharedModule, HomeRoutingModule, NzTableModule],
})
export class HomeModule {}
