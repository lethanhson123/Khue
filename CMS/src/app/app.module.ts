import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CKEditorModule } from 'ngx-ckeditor';
import { ChartsModule } from 'ng2-charts';
import { CookieService } from 'ngx-cookie-service';
import { MAT_DATE_LOCALE } from '@angular/material/core';
import { MaterialModule } from './material/material.module';
import { GoogleMapsModule } from '@angular/google-maps';
import { NotificationService } from './shared/Notification.service';
import { AppComponent } from './app.component';
import { LoadingComponent } from './loading/loading.component';
import { HomepageComponent } from './homepage/homepage.component';
import { DanhMucDuAnComponent } from './danh-muc-du-an/danh-muc-du-an.component';
import { DanhMucSanPhamComponent } from './danh-muc-san-pham/danh-muc-san-pham.component';
import { HoaDonChiTietComponent } from './hoa-don-chi-tiet/hoa-don-chi-tiet.component';
import { ThanhVienComponent } from './thanh-vien/thanh-vien.component';


@NgModule({
  declarations: [
    AppComponent,
    LoadingComponent,
    HomepageComponent,
    DanhMucDuAnComponent,
    DanhMucSanPhamComponent,
    HoaDonChiTietComponent,
    ThanhVienComponent,  
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'serverApp' }),
    FormsModule,
    HttpClientModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MaterialModule,
    GoogleMapsModule,
    ChartsModule,
    CKEditorModule,
  ],
  providers: [
    CookieService,
    NotificationService,
    { provide: MAT_DATE_LOCALE, useValue: 'en-GB' }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
