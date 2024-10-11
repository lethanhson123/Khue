import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomepageComponent } from './homepage/homepage.component';
import { DanhMucDuAnComponent } from './danh-muc-du-an/danh-muc-du-an.component';
import { DanhMucSanPhamComponent } from './danh-muc-san-pham/danh-muc-san-pham.component';
import { ThanhVienComponent } from './thanh-vien/thanh-vien.component';
import { HoaDonChiTietComponent } from './hoa-don-chi-tiet/hoa-don-chi-tiet.component';


const routes: Routes = [
  { path: '', redirectTo: '/HoaDonChiTiet', pathMatch: 'full' },
  {
    path: 'Homepage', component: HomepageComponent,
  },
  {
    path: 'DanhMucDuAn', component: DanhMucDuAnComponent,
  },
  {
    path: 'DanhMucSanPham', component: DanhMucSanPhamComponent,
  },
  {
    path: 'ThanhVien', component: ThanhVienComponent,
  },
  {
    path: 'HoaDonChiTiet', component: HoaDonChiTietComponent,
  },

];

@NgModule({
  imports: [RouterModule.forRoot(routes, { useHash: true, initialNavigation: 'enabled' })],
  exports: [RouterModule]
})
export class AppRoutingModule { }









































































