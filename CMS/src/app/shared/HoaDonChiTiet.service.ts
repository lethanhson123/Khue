import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { HoaDonChiTiet } from 'src/app/shared/HoaDonChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class HoaDonChiTietService extends BaseService{

    DisplayColumns001: string[] = ['STT', 'NgayGhiNhan', 'DanhMucDuAnID', 'ThanhVienID', 'SoLuong', 'Save'];

    List: HoaDonChiTiet[] | undefined;
    ListFilter: HoaDonChiTiet[] | undefined;
    FormData!: HoaDonChiTiet;    

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "HoaDonChiTiet";
    }

    GetByDanhMucDuAnID_ThanhVienID_BatDau_KetThucToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByDanhMucDuAnID_ThanhVienID_BatDau_KetThucToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByDanhMucDuAnID_ThanhVienID_BatDau_KetThuc_EmptyToListAsync() {        
        let url = this.APIURL + this.Controller + '/GetByDanhMucDuAnID_ThanhVienID_BatDau_KetThuc_EmptyToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

