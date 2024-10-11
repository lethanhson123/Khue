import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DanhMucSanPham } from 'src/app/shared/DanhMucSanPham.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DanhMucSanPhamService extends BaseService{

    DisplayColumns001: string[] = ['STT', 'Name', 'DonGia', 'Save'];

    List: DanhMucSanPham[] | undefined;
    ListFilter: DanhMucSanPham[] | undefined;
    FormData!: DanhMucSanPham;    

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DanhMucSanPham";
    }
}

