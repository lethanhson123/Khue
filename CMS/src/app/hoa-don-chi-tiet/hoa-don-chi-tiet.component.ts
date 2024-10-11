import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MatDialogConfig } from '@angular/material/dialog';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { NotificationService } from 'src/app/shared/Notification.service';
import { DownloadService } from 'src/app/shared/Download.service';


import { HoaDonChiTiet } from 'src/app/shared/HoaDonChiTiet.model';
import { HoaDonChiTietService } from 'src/app/shared/HoaDonChiTiet.service';

import { DanhMucDuAn } from 'src/app/shared/DanhMucDuAn.model';
import { DanhMucDuAnService } from 'src/app/shared/DanhMucDuAn.service';

import { ThanhVien } from 'src/app/shared/ThanhVien.model';
import { ThanhVienService } from 'src/app/shared/ThanhVien.service';

@Component({
  selector: 'app-hoa-don-chi-tiet',
  templateUrl: './hoa-don-chi-tiet.component.html',
  styleUrls: ['./hoa-don-chi-tiet.component.css']
})
export class HoaDonChiTietComponent implements OnInit {

  @ViewChild('HoaDonChiTietSort') HoaDonChiTietSort: MatSort;
  @ViewChild('HoaDonChiTietPaginator') HoaDonChiTietPaginator: MatPaginator;

  constructor(
    private dialog: MatDialog,
    public NotificationService: NotificationService,
    public DownloadService: DownloadService,

    public HoaDonChiTietService: HoaDonChiTietService,

    public ThanhVienService: ThanhVienService,
    public DanhMucDuAnService: DanhMucDuAnService,
  ) { }

  ngOnInit(): void {
    this.DanhMucDuAnSearch();
    this.ThanhVienSearch();
  }

  DateBatDau(value) {
    this.HoaDonChiTietService.BaseParameter.BatDau = new Date(value);
  }
  DateKetThuc(value) {
    this.HoaDonChiTietService.BaseParameter.KetThuc = new Date(value);
  }
  DateNgayGhiNhan(element: HoaDonChiTiet, value) {
    element.NgayGhiNhan = new Date(value);
  }
  DanhMucDuAnSearch() {
    this.DanhMucDuAnService.ComponentGetAllToListRefreshAsync(this.HoaDonChiTietService);
  }
  ThanhVienSearch() {
    this.ThanhVienService.ComponentGetAllToListRefreshAsync(this.HoaDonChiTietService);
  }
  HoaDonChiTietSearch() {

    this.HoaDonChiTietService.IsShowLoading = true;
    this.HoaDonChiTietService.GetByDanhMucDuAnID_ThanhVienID_BatDau_KetThuc_EmptyToListAsync().subscribe(
      res => {
        this.HoaDonChiTietService.List = (res as HoaDonChiTiet[]);
        this.HoaDonChiTietService.DataSource = new MatTableDataSource(this.HoaDonChiTietService.List);
        this.HoaDonChiTietService.DataSource.sort = this.HoaDonChiTietSort;
        this.HoaDonChiTietService.DataSource.paginator = this.HoaDonChiTietPaginator;
        if (this.HoaDonChiTietService.List) {
          this.HoaDonChiTietService.BaseParameter.TongCong = 0;
          for (let i = 0; i < this.HoaDonChiTietService.List.length; i++) {
            let HoaDonChiTiet = this.HoaDonChiTietService.List[i];
            if (HoaDonChiTiet.ID > 0) {
              this.HoaDonChiTietService.BaseParameter.TongCong = this.HoaDonChiTietService.BaseParameter.TongCong + HoaDonChiTiet.SoLuong;
            }
          }
        }
      },
      err => {
      },
      () => {
        this.HoaDonChiTietService.IsShowLoading = false;
      }
    );

  }
  HoaDonChiTietSave(element: HoaDonChiTiet) {

    this.HoaDonChiTietService.IsShowLoading = true;
    this.HoaDonChiTietService.FormData = element;
    this.HoaDonChiTietService.SaveAsync().subscribe(
      res => {
        this.HoaDonChiTietSearch();
        this.NotificationService.warn(environment.SaveSuccess);
      },
      err => {
        this.NotificationService.warn(environment.SaveNotSuccess);
      },
      () => {
        this.HoaDonChiTietService.IsShowLoading = false;
      }
    );

  }
  HoaDonChiTietDelete(element: HoaDonChiTiet) {
    this.HoaDonChiTietService.IsShowLoading = true;
    this.HoaDonChiTietService.BaseParameter.ID = element.ID;
    this.HoaDonChiTietService.RemoveAsync().subscribe(
      res => {
        this.HoaDonChiTietSearch();
        this.NotificationService.warn(environment.DeleteSuccess);
      },
      err => {
        this.NotificationService.warn(environment.DeleteNotSuccess);
      },
      () => {
        this.HoaDonChiTietService.IsShowLoading = false;
      }
    );
  }
}