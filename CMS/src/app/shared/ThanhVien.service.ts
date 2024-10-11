import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ThanhVien } from 'src/app/shared/ThanhVien.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ThanhVienService extends BaseService{

    DisplayColumns001: string[] = ['STT', 'Name', 'DienThoai', 'CCCD', 'NganHangTaiKhoan', 'NganHang', 'Save'];

    List: ThanhVien[] | undefined;
    ListFilter: ThanhVien[] | undefined;
    FormData!: ThanhVien;    

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ThanhVien";
    }
}

