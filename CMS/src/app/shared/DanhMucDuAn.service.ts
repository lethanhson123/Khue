import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DanhMucDuAn } from 'src/app/shared/DanhMucDuAn.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DanhMucDuAnService extends BaseService{

    DisplayColumns001: string[] = ['STT', 'Name', 'Note', 'Save'];

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DanhMucDuAn";
    }
}

